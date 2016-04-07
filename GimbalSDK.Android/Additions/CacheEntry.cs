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

namespace Com.Gimbal.Internal.Cache 
{
    public partial class CacheEntry
    {
        //add java lang object compareTo which for some reason refuses to be found in source jar
        public int CompareTo(Java.Lang.Object o)
        {
            return CompareTo((CacheEntry)o);
        }
    }
}