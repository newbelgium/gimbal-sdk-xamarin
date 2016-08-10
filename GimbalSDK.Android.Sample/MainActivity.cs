using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GimbalSDK.Android.Sample
{
    [Activity(Label = "GimbalSDK.Android.Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        GimbalPlaceEventListener gimbalPlaceEventListener;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //fire up gimbal - be sure to change your package name to match what you have set up in gimbal - the manifest has all the needed permissions
            Com.Gimbal.Android.Gimbal.SetApiKey(Application, "YOUR_API_KEY_HERE");
            //this class will log beacon hits and place entry/exits
            gimbalPlaceEventListener = new Sample.GimbalPlaceEventListener();
            //add it as a listener to the placemanager
            Com.Gimbal.Android.PlaceManager.Instance.AddListener(gimbalPlaceEventListener);
            //for local notifications, this will (i believe) set up messaging, though more work would have to be done for real GCM setup
            Com.Gimbal.Android.CommunicationManager.Instance.StartReceivingCommunications();
            //and tell gimbal to start looking
            Com.Gimbal.Android.PlaceManager.Instance.StartMonitoring();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

