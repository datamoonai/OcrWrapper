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
        Console.WriteLine(ocrWrapper.SetLicenseKey("gAAAAABnL1TbS2LsYcQjWe4WTmFFDhi1GM2Qc1c4sij_mCzNarjo_wsVW_io7zufSBcbfqEm-RsQ-HUotok4ZTggmOYa5KYXHRxVAySINHAXDsohD-N4NIDLHpjyPrm6nrrrXOGZlMEI3lseGJSFLiqW2a5ksWWTYPO83eP-R9fdI2aA0XXIJi9v45vQ1OzTEMmyMHl80bzIVwnJ30ivQY2-iK7krnwEZo7WUs9J9TbZDLPnwPJi8EsTdw_3rzwPLci2pJodOilxvYKx3hXrub1LRWCW3cfy9Lnn1eWnzuFSK3su7agvR1AGu4fP3bt3PGZw-hP1gPykdP6J6--jmZJd7EzYtLdFztuS0_g8gi07B78PgvSyUdLS2dOxnZFG36yBX5Zym6w8MBDlXjyoMspgiK5eJ_XSF9J319Rc0SIzhzgBaEqTCSJCOaHrn-E2qeWt1r0iYD32I4D8dzrv_t28nCCuW-dvGa7Hj4fdEcv8IOsJB5Ay3Xh2wlTKqGEqaJtn12j8JVE8RyYJ9NwiwXnB3K2crDhDfWc1vPmvOSGP1TrnohHtwzxHRJEWUNh6y4oCgKsz5z2virL2Ft6-aKZ-geLMXxJBJ0ZXYz0ijHe4zozUqhFi39HS4VVz59keGW1CpxEfGypzuQ29E4Ic7D96CocWG1xtHeYwtrVVdXyFl2Rfe8Vtjp-Yx_MgE5dvbbtTO3kD19fpvg_ojuFpDw7dpDuMVMhz1BmPBHvOiC6DMsSlHg4M_4zZaMqBT_8-tdL7vQ40wvjh5pY8M8ybD6KyOl4aIsonlyZcxI8BrGnhfTLb5BivJh8KEmnkTplTg2r-YXLFvnToP3KIvZ0V-EDlQiMgeHLe8jI6bcig4FPw8kpvp-_jrbjVC5bptGIlvVxa2vS2tkaeDtmmmfpUM1OZKzT0Wsz6bUN-JqFdve4qnQZ2JImAQvqRJAOVmmzjlTvkmOevt4lHCzJa2oFHW9qNuSr4ZOdItjJEHRwwnSTt0mOFzfZixTDhIGI_w1s2_D8hxzU5xpDozhgE8AsMay4DEj97tPJgSUz91ldZRbTF8qhYD2eBfHAPfuD8vii2K3T-O333Hvipn1b0VAc9S8IRFseQolRxqnveImzu6anyO03yVqPppIeGlzjby7xJzd2h5agJJhDQ_9RZO-WFSo_K_4GYUSgkW59pH2ANb0ugHF_khvxBwj7pPGBv8Mm5FmX5jYP0UG68QNR-BLa5ZAuz-spgLTz53dsuwoKO4aDujs1ONEMdicS0ebaBY92Yt2Qso6sTJMXf6MbxldbFDhLEbGxllKEYSkS3Lr7Oqr2DeHyW3NJxyGOh0CQSSHcpYoWKgerCp1ucwhE8onVSKiqb29ZXQntjeXLtD-mIlQPVp1lvGcmEJoTMjqK38RFpmOxveFc_2xT68BGWMDNzgHXElW9DmM20Qip-FKDoPeioZgRtI6OyMPxVcZJmqM6I615MFFPFMBLFi4fJzzWWOhZZ2NKWDFeUZNscAw2svd2fs4cyPfKDxSERrDDGeS1SGppTF8ob6MZnLdpiKpLQNyDRmA2dz8Ynsbn_XSOrN_25RAFNOybhnCdPAVRN-SFGLH_M01eTkaQm5w0bUfKP-AC55Gj8NOkaLWTEstxEDyvx5cVV-vmiIDJ8xRbNbS5ld7jK35PlqlHw_WwnqC5891Fh5xO6hkMUhDkjXKYGzJZcAC_F0-Fy1sXc4qWwGB3IblX-rEH4Jlxy"));
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
