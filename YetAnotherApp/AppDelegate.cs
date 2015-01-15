using System;
using System.Collections.Generic;
using System.Linq;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;

namespace YetAnotherAppIOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;
        UINavigationController nav;
        ViewController controller;
        UICollectionViewFlowLayout flowLayout;

        public override void FinishedLaunching (UIApplication application)
        {
            Forms.Init ();

            window = new UIWindow (UIScreen.MainScreen.Bounds);

            flowLayout = new UICollectionViewFlowLayout (){
                SectionInset = new UIEdgeInsets (25,20,10,20),
                MinimumInteritemSpacing = 5,
                MinimumLineSpacing = 10,
                ItemSize = new CGSize (150, 150)
            };

            controller = new ViewController (flowLayout);
            nav = new UINavigationController (controller);
            window.RootViewController = nav;
            window.MakeKeyAndVisible ();
        }
    }
}