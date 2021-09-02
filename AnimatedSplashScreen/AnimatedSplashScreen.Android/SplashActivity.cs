using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Airbnb.Lottie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimatedSplashScreen.Droid
{
    [Activity(Label = "SplashActivity",MainLauncher =true,
        NoHistory =true, Theme = "@style/SplashTheme")]
    public class SplashActivity : Activity, Animator.IAnimatorListener
    {
        public void OnAnimationCancel(Animator animation)
        {
           
        }

        public void OnAnimationEnd(Animator animation)
        {
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        public void OnAnimationRepeat(Animator animation)
        {
            
        }

        public void OnAnimationStart(Animator animation)
        {
           
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_Splah);
            var animationView = FindViewById<LottieAnimationView>(Resource.Id.animation_view);
            animationView.AddAnimatorListener(this);
        }

    }
}