using System;
using ObjCRuntime;

namespace GimbalFramework
{   
    [Native]
    public enum GMBLLocationStatus : long /*: nint*/
    {
	    Ok,
	    AdminRestricted,
	    NotAuthorizedAlways
    }

    [Native]
    public enum GMBLBluetoothStatus : long /*: nint*/
    {
	    Ok,
	    AdminRestricted,
	    PoweredOff
    }

    [Native]
	public enum GMBLBatteryLevel : long /*: nint*/
    {
	    Low = 0,
	    MediumLow,
	    MediumHigh,
	    High
    }
}

namespace GimbalExperienceFramework
{
    [Native]
    public enum GMBLActionType : long /*: nint*/
    {
        Unknown,
        WebView,
        Carousel,
        Image,
        Video,
        Audio
    }

    [Native]
    public enum GMBLForegroundBehavior : long /*: nint*/
    {
        Unknown,
        Noop,
        Notify,
        Dialog,
        Display,
        Play
    }
}