# gimbal-sdk-xamarin
Xamarin bindings for the Gimbal SDKs

# GimbalSDK.Android.Sample
A sample project for Android.  Run after building the Android binding project since it has a file path reference to the DLL generated from that project. Also uses nuget packages for Xamarin.Android.Support.v4, Xamarin.GooglePlayServices.Base, Basement, GCM, and Measurement. All this project really does is show Gimbal configuration and then log Gimbal events for beacon sightings and place entries and exits (the UI is just the default Xamarin project UI).  Be sure to change your package name to something you have configured with Gimbal (and optionally Google for GCM), and then put your Gimbal project API key in the MainActivity.

# GimbalSDK.Android
The Android bindings.  Build on appropriate OS.  Should not need anything additional other than local Android SDK stuff.

# GimbalSDK.iOS-Unified
The iOS bindings.  Build on Mac in Xamarin Studio.  Should not need any additional configuration.

# GimbalSDK.iOS.Sample
Coming soon.

# UrbanAirshipAdapters
C# translations of classes used for forwarding Gimbal place events to Urban Airship for UA-based messaging.  Only required if you need them.  Copy and place in your project where you'd like.  Customize at will.

# source
Gimbal SDKs kept for reference.  They have already been unpacked into the appropriate places in the projects, so there's nothing to do with them here.
