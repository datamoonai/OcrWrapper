using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Python.Runtime;

public class OcrWrapper
{
    private dynamic _finder;
    private dynamic _np;
    public OcrWrapper()
    {
        // Set the environment variables
        string pythonHome = @"OCREngine\Runtime"; // Change this to your Python installation path
        string pythonDLL = @"OCREngine\Runtime\python310.dll"; // Adjust based on your version
        string customLibPath = @"OCREngine\Runtime\Lib"; // Change this to your actual path

        Environment.SetEnvironmentVariable("PYTHONHOME", pythonHome);
        Environment.SetEnvironmentVariable("PYTHONPATH", pythonHome + @"\Lib\site-packages");

        // Initialize the Python engine
        Runtime.PythonDLL = pythonDLL; // Specify the Python DLL
        PythonEngine.Initialize();

        using (Py.GIL())
        {
            dynamic sys = Py.Import("sys");
            sys.path.append(customLibPath);
            sys.path.append("OCREngine");
            _finder = Py.Import("finder");
            _np = Py.Import("numpy");
        }
    }

    public PyObject GetLicenseKey()
    {
        using (Py.GIL())
        {
            PyObject result = _finder.get_key();
            return result;
        }
    }

    public PyObject SetLicenseKey(string license)
    {
        using (Py.GIL())
        {
            PyObject result = _finder.set_key(license);
            return result;
        }
    }

    public PyObject OCR(Bitmap bitmap)
    {
        DateTime dt = DateTime.Now;

        int width = bitmap.Width;
        int height = bitmap.Height;

        // Create a byte array to hold BGR values
        byte[] pixelData = new byte[width * height * 3];

        // Lock the bits of the bitmap
        Rectangle rect = new Rectangle(0, 0, width, height);
        BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

        // Get the address of the first pixel
        IntPtr ptr = bmpData.Scan0;

        // Get the stride of the bitmap
        int stride = bmpData.Stride;

        // Copy the pixel data to the byte array and convert to BGR format
        unsafe
        {
            byte* ptrByte = (byte*)ptr;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int offset = (y * stride) + (x * 3);
                    pixelData[(y * width + x) * 3] = ptrByte[offset]; // Blue
                    pixelData[(y * width + x) * 3 + 1] = ptrByte[offset + 1]; // Green
                    pixelData[(y * width + x) * 3 + 2] = ptrByte[offset + 2]; // Red
                }
            }
        }

        // Unlock the bits
        bitmap.UnlockBits(bmpData);

        // Create a NumPy array from the pixel data
        dynamic numpyArray = _np.frombuffer(pixelData, dtype: _np.uint8);

        //numpyArray = numpyArray[:, :, ::- 1];
        //Console.WriteLine("This part of code " + (DateTime.Now - dt).TotalMilliseconds);

        numpyArray = numpyArray.reshape(height, width, 3); // Reshape to (height, width, 3)

        using (Py.GIL())
        {
            PyObject result = _finder.finder.ocr_bgr(numpyArray);
            //Console.WriteLine("Second part of code " + (DateTime.Now - dt).TotalMilliseconds);

            return result;
        }
    }
}

