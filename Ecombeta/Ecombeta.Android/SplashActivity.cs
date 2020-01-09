﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ecombeta.Droid
{
    [Activity(Label = "Mica Market", Theme = "@style/Splash", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            System.Threading.Thread.Sleep(300);
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
     
           
            // Create your application here
        }
    }
}