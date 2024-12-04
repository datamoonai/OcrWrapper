using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Scripting.Runtime;
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

        // Lock the bits of the bitmap
        Rectangle rect = new Rectangle(0, 0, width, height);
        BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

        // Get the address of the first pixel
        IntPtr ptr = bmpData.Scan0;

        // Get the stride of the bitmap
        int stride = bmpData.Stride;

        PyObject result = OCR(width, height, stride, ptr);

        bitmap.UnlockBits(bmpData);

        return result;

    }

    public PyObject OCR(int width, int height, int stride, IntPtr ptr)
    {
        using (Py.GIL())
        {
            PyObject result = _finder.ocr_bgr(width, height, stride, ptr.ToInt64());

            return result;
        }

    }
}

