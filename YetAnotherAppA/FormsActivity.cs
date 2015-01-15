
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
using Xamarin.Forms;
using YetAnotherAppAndroid;
using Xamarin.Forms.Platform.Android;
using YetAnotherAppShared;

namespace YetAnotherAppAndroid
{
    [Activity (Label = "FormsActivity")]			
    public class FormsActivity : FormsApplicationActivity
    {
        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            string imagesource = Intent.GetStringExtra ("imagesource");

            Forms.Init(this, savedInstanceState);

            #pragma warning disable 618

            SetPage (new DetailPage (imagesource));
        }
    }
}