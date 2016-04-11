using System;
using ObjCRuntime;

[assembly: LinkWith ("libGimbal.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
