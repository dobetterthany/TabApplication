using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using System.IO;
using Android.Content;

namespace TabApplication
{
    [Activity(Label = "City Selection", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            TabHost.TabSpec tabSpec;
            Intent intent;

            intent = new Intent(this, typeof(HomeActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Auckland");
            tabSpec.SetIndicator("Home");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);

            intent = new Intent(this, typeof(Christchurch));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("");
            tabSpec.SetIndicator("Home");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);

            intent = new Intent(this, typeof(Wellington));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Auckland");
            tabSpec.SetIndicator("Home");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);

            intent = new Intent(this, typeof(NewPlymouth));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Auckland");
            tabSpec.SetIndicator("Home");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}