using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace dailymotion {

	[BaseType (typeof (UIViewController), Delegates= new string [] {"WeakDelegate"}, Events=new Type [] { typeof (DMPlayerDelegate) })]
	interface DMPlayerViewController {

		//------------------------------
		//			CONSTRUCTOR
		//------------------------------

		[Export("initWithVideo:")]
		IntPtr Constructor (string videoId);


		[Export("initWithVideo:params:")]
		IntPtr Constructor (string videoId, NSDictionary parameters);


		//------------------------------
		//			DELEGATE
		//------------------------------

		//delegate
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")][NullAllowed]
		DMPlayerDelegate Delegate { get; set; }



		//------------------------------
		//			METHODS
		//------------------------------

//		- (void)play;
		[Export("play")]
		void Play();

//		- (void)togglePlay;
		[Export("togglePlay")]
		void TogglePlay();

//		- (void)pause;
		[Export("pause")]
		void Pause();

//		- (void)load:(NSString *)videoId;
		[Export("load:")]
		void Load(string videoId);

//		- (void)api:(NSString *)method arg:(NSString *)arg;
		[Export("api:arg:")]
		void Api(string method, string arg);

//		- (void)api:(NSString *)method;
		[Export("api:")]
		void Api(string method);







		//------------------------------
		//			PROPERTIES
		//------------------------------

		[Export ("autoplay")]
		bool Autoplay { get; }

		[Export ("currentTime")]
		float CurrentTime { get; set; }

		[Export ("bufferedTime")]
		float BufferedTime { get; }

		[Export ("duration")]
		float Duration { get; }

		[Export ("seeking")]
		bool Seeking { get; }

		[Export ("paused")]
		bool Paused { get; }

		[Export ("ended")]
		bool Ended { get; }

		[Export ("muted")]
		bool Muted { get; set; }

		[Export ("volume")]
		float Volume { get; set; }

		[Export ("fullscreen")]
		bool Fullscreen { get; set; }

		[Export ("error")]
		NSError Error { get; }

		[Export ("webBaseURLString")]
		string WebBaseURLString { get; set; }

	}


	[BaseType (typeof (NSObject))]
	[Model][Protocol]
	interface DMPlayerDelegate {

		[Export ("dailymotionPlayer:didReceiveEvent:"), EventArgs ("DMPlayerViewControllerDidReceiveEvent")]
		void DidReceiveEvent (DMPlayerViewController player, string eventName);


		/*
		//methods delegate
		//- (BOOL)webView:(UIWebView *)webView shouldStartLoadWithRequest:(NSURLRequest *)request navigationType:(UIWebViewNavigationType)navigationType
		[Export("webView:shouldStartLoadWithRequest:navigationType:"), EventArgs ("DMPlayerViewControllerShouldStartLoad")]
		bool ShouldStartLoad (UIWebView webView, MonoTouch.Foundation.NSUrlRequest request, UIWebViewNavigationType navigationType);

		//		- (void)webViewDidStartLoad:(UIWebView *)webView
		[Export("webViewDidStartLoad:"), EventArgs ("DMPlayerViewControllerLoadStarted")]
		void LoadStarted (UIWebView webView);

		//		- (void)webViewDidFinishLoad:(UIWebView *)webView
		[Export("webViewDidFinishLoad:"), EventArgs ("DMPlayerViewControllerLoadingFinished")]
		void LoadingFinished (UIWebView webView);

		//		- (void)webView:(UIWebView *)webView didFailLoadWithError:(NSError *)error
		[Export("webView:didFailLoadWithError:"), EventArgs ("DMPlayerViewControllerLoadFailed")]
		void LoadFailed (UIWebView webView, MonoTouch.Foundation.NSError error);
		*/


	}


}

