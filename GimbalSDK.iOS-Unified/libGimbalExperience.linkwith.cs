using System;
using ObjCRuntime;

[assembly: LinkWith ("libGimbalExperience.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
