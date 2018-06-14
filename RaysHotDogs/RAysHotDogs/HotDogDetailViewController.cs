using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;

namespace RAysHotDogs
{
    public partial class HotDogDetailViewController : UIViewController
    {

        public HotDog SelectedHotDog { get; set; }



        public HotDogDetailViewController (IntPtr handle) : base (handle)
        {
            HotDogDetailServices hotDogDataService = new HotDogDetailServices();
            SelectedHotDog = hotDogDataService.GetHotDogById(1);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DataBindUI();
            AddToChartButton.TouchUpInside += (object s, EventArgs e) =>
            {
                UIAlertView message = new UIAlertView(){
                    Title="Works Well",
                    Message= "First HOTDOG!!!"
                };
                message.AddButton("Ok");
                message.Show();
                this.DismissModalViewController(true);
            };

            CancelButton.TouchUpInside+=(object s, EventArgs e)=>
            {
                this.DismissModalViewController(true);
            };

        }
        private void DataBindUI()
        {
            UIImage img = UIImage.FromFile("Images/" + SelectedHotDog.ImagePath + ".jpg");
            HotDogImageView.Image =img;
            HotDogName.Text = SelectedHotDog.Name;
            ShortDescriptionLabel.Text = SelectedHotDog.ShortDescription;
            LongDescriptionText.Text = SelectedHotDog.Description;
            PriceLabel.Text = "$" + SelectedHotDog.Price;

        }





    }
}