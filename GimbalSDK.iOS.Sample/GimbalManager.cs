using CoreLocation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GimbalSDK.iOS.Sample
{
    class GimbalManager : CLLocationManagerDelegate
    {
        private GimbalFramework.GMBLPlaceManager placeManager;
        private GimbalPlaceManagerDelegate gimbalPlaceManagerDelegate;

        public GimbalManager()
        {
            gimbalPlaceManagerDelegate = new GimbalPlaceManagerDelegate();
            placeManager = new GimbalFramework.GMBLPlaceManager();
            placeManager.Delegate = gimbalPlaceManagerDelegate;
        }

        //from CLLocationManagerDelegate, if auth changes to always, start services
        public override void AuthorizationChanged(CLLocationManager manager, CLAuthorizationStatus status)
        {
            if (status == CLAuthorizationStatus.AuthorizedAlways)
            {
                Start();
            }
        }

        //start gimbal services for getting notifications and for listening for places/beacons
        public void Start()
        {
            GimbalFramework.GMBLCommunicationManager.StartReceivingCommunications();
            GimbalFramework.GMBLPlaceManager.StartMonitoring();
        }
    }
}
