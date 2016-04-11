# gimbal-sdk-xamarin
Xamarin bindings for the Gimbal SDKs

#iosnotes

install objective sharpie
unzip framework
place in convenient location
terminal
cd to location
sharpie bind -sdk iphoneos9.2 Gimbal.framework/Versions/2.36.1/Headers/Gimbal.h -scope Gimbal.framework/Headers -c -F Gimbal.framework/Versions/2.36.1/Headers

paths may need to be adjusted in above command
may need to copy files not found in includes to a subfolder "Gimbal/whatever" so they are found
may need to adjust includes in main header file if complaint about <angled>



Binding Analysis:
  Automated binding is complete, but there are a few APIs which have been flagged with [Verify] attributes. While the entire binding should be audited for best
  API design practices, look more closely at APIs with the following Verify attribute hints:

  MethodToProperty (11 instances):
    An Objective-C method was bound as a C# property due to convention such as taking no parameters and returning a value (non-void return). Often methods like
    these should be bound as properties to surface a nicer API, but sometimes false-positives can occur and the binding should actually be a method.

  StronglyTypedNSArray (6 instances):
    A native NSArray* was bound as NSObject[]. It might be possible to more strongly type the array in the binding based on expectations set through API
    documentation (e.g. comments in the header file) or by examining the array contents through testing. For example, an NSArray* containing only NSNumber*
    instances can be bound as NSNumber[] instead of NSObject[].

  Once you have verified a Verify attribute, you should remove it from the binding source code. The presence of Verify attributes intentionally cause build
  failures.
  
  For more information about the Verify attribute hints above, consult the Objective Sharpie documentation by running 'sharpie docs' or visiting the following
  URL:

    http://xmn.io/sharpie-docs

Submitting usage data to Xamarin...
  Submitted - thank you for helping to improve Objective Sharpie!

Done.




ditto for gimbalexperience framework

Binding Analysis:
  Automated binding is complete, but there are a few APIs which have been flagged with [Verify] attributes. While the entire binding should be audited for best
  API design practices, look more closely at APIs with the following Verify attribute hints:

  StronglyTypedNSArray (3 instances):
    A native NSArray* was bound as NSObject[]. It might be possible to more strongly type the array in the binding based on expectations set through API
    documentation (e.g. comments in the header file) or by examining the array contents through testing. For example, an NSArray* containing only NSNumber*
    instances can be bound as NSNumber[] instead of NSObject[].

  MethodToProperty (1 instance):
    An Objective-C method was bound as a C# property due to convention such as taking no parameters and returning a value (non-void return). Often methods like
    these should be bound as properties to surface a nicer API, but sometimes false-positives can occur and the binding should actually be a method.

  Once you have verified a Verify attribute, you should remove it from the binding source code. The presence of Verify attributes intentionally cause build
  failures.
  
  For more information about the Verify attribute hints above, consult the Objective Sharpie documentation by running 'sharpie docs' or visiting the following
  URL:

    http://xmn.io/sharpie-docs

Submitting usage data to Xamarin...
  Submitted - thank you for helping to improve Objective Sharpie!

Done.


