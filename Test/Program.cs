﻿using System;
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
        Console.WriteLine(ocrWrapper.SetLicenseKey("gAAAAABnVDGtHdLoliJjb4HWVDscVmKS-l1RtFVTzB7iiabk9n-nWMLKae7wPevd78U6LZykSOye90j7OqlPKEjk99k5kwYdWuESR02A3qsjWuTamzGSp8-vzCDcmm6UTR_LZ6eNtJvx_Q25hqsW57bhqz2ZXps7TB1QX-8luAFP0fMM9mYoc9nXOQwnH6O7muXuwBgCD6JMS_lnnyLiqMPkk5UxABei0he-8pGmG8doefq0W3SpOHQFwXHcTn7quBz7ZTPQYmLs808SY0nfhTdEVvCIQJARHmCTuUzuqLSFRAjmVa6yarTEk6DHV3oTgOxEAbFzaKeh7pNn6WGaqpU-uj1q2qsIweuyuuSmld9pr-PX24Jwn48gbCIScmD4Thm5lfcZ_k3VlCNwY7bkZ0InKEN-rlb7woWH9g1ssYSa43dP3x5Up0XdYs3uhnNwX-Rop-qqUgScVo7OVtpCH6ZDgfEPTD-VfZ_UfyEpBr5ngCbUfjm5iwwwc8J2z_qmHkZpW3ndJG6RPusRj51qDMcZp9dVWULGKUDnsVEH79J3w9q17GsXL1gK_bMQ1Pl5uWSGPrVEuDvN_KilNtOLU-1AtEJTXeiaY8hHckzKfHAn4dp1kyI_sxEEiIEgGllORETu4J1jcjE-uKGdN1AjbDaFdHbKW-j7KCfyn73hKwzgeEOmWhMw8whPDcvCX6hUOFxnNSEdqEvB3M4ovxBQIoKom7QBazpeM_Eohrb9AR7Wh1cL0QCNou0x3Z_euv1lQsxPpLj1wJ2XkZxeFt440PuVB8T6XOQ8o-fYyEHnHy2pyTCRGjhOBTY3-QYp_C_ig8w13g2FirKaHHRRNA5Ivlh8feL6N5e-7_p3mQoq1KXdk04cPGg7KNI4Uuwq5s6LTV4ZlMAfabsVR3eoG6jIDbMt_Jep9k0gNQ2RbyQXFDig7HPIwKKO6Fn78HWZu1IS8xDknmzG52pBNcOXM8g_sL0JExQmos0_ZjeZnrA6Z1Y9eG2oI5mL_kn10-A8Yo0wXVTHPz50lv2-HHYOh3YsvZCxGSDihu6jbuSpwXA-7za8zATJCJ0afuftVlRac5RCTpEMql5oXmCEDpu4PDB-0WAI83mEkwpIiSRTlu1N6nB6mp_ZAP5KCVwTh97IosScW_3DptRB2HBL5r_CYqicHnwtvM6z0hXEo_4R2KiupNSPiQ1CrfV1wFm85UxIYU8Rg7iTNMRzgYqWQA2zPThy5PGqJrERphPvX1x7uTKTAEJfS0ZEFKI4kID90f8wPywZPR6IH4VfGmvqztIRuarw1vVmKWetnp2cfrsNBW9JBw6inWajJkPthsKLdbSmvDkaGS-f90UHJWaXtb__fyxyk8XJiIM3MT5ToU_Ki_vOAlzW00yY5sNeJP1_DAOfziIDQFUAONGNQg8Kh4eJBFTNe2IdL7YdqL5bv0xvKBmXPU4ZqmqwcvI5ocT2GcWgf5wLdRLLmtkVT3Qi1S0Ucwct8uTUutJbLgnG8hrVLorToptktYqddpRv-hH0fwrJLjeBP_N308KCSYN7v1UmI4xd-UCZgiwwGAGeodeZ0tSrFu14FZsIkvg9YXqqQGtipphGUQBi9EmnGywuOkLtjes7wBpbZ0f_h0DAidxj2HAPFlRg9n2gfcG5ib1RcPkVDWaSA3x2_uOa_GCHAw1ldQhddmNTWgU6CRMg-Oms7DbnIzcuhOD-Ozzgm5Vs5EcZ5uEB4MTV380D614yC3neSCO66Rukeg7uSC7Jgg60aWogtONwNnAyVEhGiTrUZp0BFjOSIAEV6p5NTdLyDJ1E694-3ue0c1SDLT7Obw=="));

        ocrWrapper.RunTest();

        Console.ReadKey();
    }




   
}
