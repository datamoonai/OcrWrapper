using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        OcrWrapper ocrWrapper = new OcrWrapper();

        // ابتدا کلید را دریافت کنیم
        Console.WriteLine("Key " + ocrWrapper.GetLicenseKey());

        // سپس مجوز را دریافت کنیم و با این تابع ست کنیم - البته این قسمت را یک مرتبه بیشتر نیاز نیست که انجام دهیم
        Console.WriteLine(ocrWrapper.SetLicenseKey("gAAAAABnMEEBorSvRCZRLhDgDAErJPfzoIbv5N1NEmOHJoYcPDZuQI6QfB5KOsT9S3rKzd1rKw-pTxt09AldXz0TBTepg8MnzqyWrOaO2THhQ4FAvrc88mMzZekcTbmKRCofgDzkbY3-q8_NX-cnG17pRjmK00T--wJYmls1KfieSGWEaqmWXY5Ai860I8GTIOj7yEDNmTyF_UxVcnQRzjtRNhyEzslbrEn2eD0DGnp9n6zkU6sXc1HK2ti5zoWjVZuwgdmP4yRXzdBomqHd109FSN9YNMLWQRtOYfIc0_Z0VN8zbYhpnBcuu_dk4fy5qfgRTvABXduL1sLwzR41HnfcJOgOAKZ6E0Cc_VRtTLzqq_P6oRDk1lDq8NLjo6IMLs0mwwV4rI2pIJc7k7KP8wZhQmTRdICnBgQub8_otcZwlKYE66zg_TfWa98dlIhC_v3Asr7Nzs79YQtmHeJZGjAB_KQxXq9EuUOrTi_cvH9_8WINT1jHZKwXXIBUE4YonQVXd9WYSPpE5dEdg_wYb9R8R7UlXNwMi2Q5Xc-PEAxGN46LjJiN55ymkGAqLM2Xkv8PtTmo92bDznL4KYl2TFI8LZtcTrlvfJji3OwVcNCS6qvv2Ptk3GNgagFNAuD0rOZdgBs9pGkmavGx77oulwvtite4nva3TLo8axS_4vZbJFM-OPCIJWdjemYv-2f5CyKReOZhK7ZBBIq9U9qypwNoCd6J7VPh5gz6YBi2TaPZ4AIqhBsGZk-E-9-ao0R-mtdPWC8qakcv1eYkRun0mx_8kU1lZCvfCNWWF-HKHTvrw888JaCN87iMDRG1wC6rp2vp_DDEfi2V2J_WI7eZK7nqVqLn-5gsr9h17OL1n4_nQUtrS7vdMYM5ra9b_xPa74uqiJa7-W54ZRpdCD7_mI1dF3zicghutMH6-znK3NH4z7MXF6EmHC9C0lQWO_-uBW73qetrgpCqgoNwFjdDYxl9LoKn3mQi06D75pp7qRCIEI9Ru-uSIAU7rUNO8lcgxAuI26I3B60Vi0caOQmPAwVbk0Ua_cNd5_wxbteJmG-b1X-x5D95fdvsCVS55DLkY3e5T8Xy71k6pcd5OVlQEQJN8OJEx7Z693yTl0nIEropkNXQvvpUfVdo1-t00HVyj3XjD6ERl6xnjA3ipZC3VQB7nTQBDcYionjYzx3xo4FL1YEMZpvZM-VxLgcFTn1hT39I5FVbdbdkvI9bhxx4c9mCvFAy6w9OEqzUaRQ-OyaKzW0xIU60mD2r0WCE9vg9mFzgEV7LNReg5Hbzki5wgbz9ZJdLK2j7jQqH-_5t3VGHz23tGW1_noPk_mE-f9gFaDPhUUFbC5A_GHNr0JajqKxOg_AeHmnR2xzSKW6B_wRQsvFpn6dBm3UDG-hnCKEIbOX9kAwgqPJSRPAVR-JFngMvq-hyVsY4h9cU4ZnKg--714NdJ1hs_J_qT4ukyMmjdFdF52LYd_61fDDqwnigG4h0dP2k1n7cqhO5TrGgHgS2Ew7Kfe2ZYd-3woqKSl2hErXycZjZAkdrXeeHD6n4ilx7amJN9tKh7__Ub-JTVGhG2tkxQ8kMhIiiS8vkEurQ1-5hrlQnL697f-pdNwASobQ47aOfjaEBY9bJwpPuifqVJaph8qSjJcM="));
        //OcrWrapper ocrWrapper2 = new OcrWrapper(pythonHome, pythonDLL, customLibPath);

        // با استفاده از این تابع نتیجه را دریافت کنیم
        string imagePath = @"test.jpg"; // Change this to your JPG file path
        using (Bitmap bitmap = new Bitmap(imagePath))
        {
            for(int i = 0; i < 10;i++)
            {
                Console.WriteLine(ocrWrapper.OCR(bitmap));
            }
                
        }

        Console.ReadKey();
    }


   
}
