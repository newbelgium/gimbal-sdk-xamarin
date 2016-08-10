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

namespace GimbalSDK.Android.Sample
{
    public static class Extensions
    {
        public static DateTime? FromUnixTime(this Java.Lang.Long unixTimeMillis)
        {
            if (unixTimeMillis == null)
                return null;
            return FromUnixTime(unixTimeMillis.LongValue());
        }

        public static DateTime? FromUnixTime(this long unixTimeMillis)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTimeMillis);
        }
    }
}