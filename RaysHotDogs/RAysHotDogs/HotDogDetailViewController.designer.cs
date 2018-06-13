// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RAysHotDogs
{
    [Register ("HotDogDetailViewController")]
    partial class HotDogDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddToChartButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AmmountText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HotDogImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HotDogName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView LongDescriptionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PriceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ShortDescriptionLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddToChartButton != null) {
                AddToChartButton.Dispose ();
                AddToChartButton = null;
            }

            if (AmmountText != null) {
                AmmountText.Dispose ();
                AmmountText = null;
            }

            if (CancelButton != null) {
                CancelButton.Dispose ();
                CancelButton = null;
            }

            if (HotDogImageView != null) {
                HotDogImageView.Dispose ();
                HotDogImageView = null;
            }

            if (HotDogName != null) {
                HotDogName.Dispose ();
                HotDogName = null;
            }

            if (LongDescriptionText != null) {
                LongDescriptionText.Dispose ();
                LongDescriptionText = null;
            }

            if (PriceLabel != null) {
                PriceLabel.Dispose ();
                PriceLabel = null;
            }

            if (ShortDescriptionLabel != null) {
                ShortDescriptionLabel.Dispose ();
                ShortDescriptionLabel = null;
            }
        }
    }
}