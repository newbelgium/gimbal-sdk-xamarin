using Foundation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GimbalSDK.iOS.Sample
{
    //logs visits, locations, beacons for gimbal
    class GimbalPlaceManagerDelegate : GimbalFramework.GMBLPlaceManagerDelegate
    {
        public override void DidBeginVisit(GimbalFramework.GMBLPlaceManager manager, GimbalFramework.GMBLVisit visit)
        {
            Console.WriteLine("Adapter DidBeginVisit: " + visit.Place.Description);
        }

        public override void DidEndVisit(GimbalFramework.GMBLPlaceManager manager, GimbalFramework.GMBLVisit visit)
        {
            Console.WriteLine("Adapter DidEndVisit: " + visit.Place.Description);
        }

        public override void DidDetectLocation(GimbalFramework.GMBLPlaceManager manager, CoreLocation.CLLocation location)
        {
            Console.WriteLine("Adapter DidDetectLocation: " + location.Coordinate.Latitude + " " + location.Coordinate.Longitude);
        }

        public override void DidReceiveBeaconSighting(GimbalFramework.GMBLPlaceManager manager, GimbalFramework.GMBLBeaconSighting sighting, NSObject[] visits)
        {
            Console.WriteLine("Adapter DidReceiveBeaconSighting: " + sighting.Beacon.Name);
        }
    }
}
