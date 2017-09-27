using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppActivosFijos.Services;
using Xamarin.Forms;
using ZXing.Mobile;
using System.Threading.Tasks;


[assembly: Dependency(typeof(AppActivosFijos.Droid.Services.QrScanningService))]

namespace AppActivosFijos.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        public async Task <string> ScanAsync()
        {
            var optionDefault = new MobileBarcodeScanningOptions();
            var optionCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Acerca la camara al código",
                BottomText = "Toca la pantalla para enfocar",

            };
            var scanResult = await scanner.Scan(optionCustom);
            return scanResult.Text;
        }
    }
}