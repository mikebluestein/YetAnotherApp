using System;
using System.Drawing;
using Foundation;
using UIKit;
using Xamarin.Forms;
using YetAnotherAppShared;

namespace YetAnotherAppIOS
{
	public class ViewController : UICollectionViewController
	{
		static readonly NSString cellId = new NSString ("ImageCell");

        Monkeys monkeys;

        public ViewController (UICollectionViewLayout layout) : base (layout)
		{
            Title = "Monkeys";

			CollectionView.ContentSize = UIScreen.MainScreen.Bounds.Size;
            CollectionView.BackgroundColor = UIColor.Black;

			monkeys = Monkeys.Instance;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CollectionView.RegisterClassForCell (typeof(ImageCell), cellId);
		}

        public override nint GetItemsCount (UICollectionView collectionView, nint section)
        {
            return monkeys.Count;
        }

        public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
        {
            var page = new DetailPage (monkeys [indexPath.Row].ImageFile);
            var vc = page.CreateViewController ();
            NavigationController.PushViewController (vc, true);
        }

		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			ImageCell imageCell = (ImageCell)collectionView.DequeueReusableCell (cellId, indexPath);

			imageCell.UpdateImage (monkeys [indexPath.Row].ImageFile);
                
			return imageCell;
		}
            
		class ImageCell : UICollectionViewCell
		{
			UIImageView imageView;

			[Export ("initWithFrame:")]
			ImageCell (RectangleF frame) : base (frame)
			{
				imageView = new UIImageView (new RectangleF (5, 5, 140, 140)); 

                imageView.ContentMode = UIViewContentMode.ScaleAspectFit;

				ContentView.AddSubview (imageView);

				BackgroundView = new UIView { BackgroundColor = UIColor.Black };

                SelectedBackgroundView = new UIView { BackgroundColor = UIColor.LightGray };
			}

            internal void UpdateImage (string path)
            {
                imageView.Image = UIImage.FromFile (path);
            }
		}
	}
}