using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libNativeLibrary.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "Security SystemConfiguration", LinkerFlags = "-ObjC")]
