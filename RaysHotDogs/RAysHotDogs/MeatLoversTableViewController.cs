// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;
using RAysHotDogs.DataSources;
using UIKit;

namespace RAysHotDogs
{
    public partial class MeatLoversTableViewController : BaseTableCategory
	{
		public MeatLoversTableViewController (IntPtr handle) : base (handle)
		{
		}
	
        HotDogDetailServices dataService = new HotDogDetailServices();

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var favoritesHotDog = dataService.GetHotDogsFromGroup(2);
            var datasource = new HotDogDataSources<MeatLoversTableViewController>(favoritesHotDog, this);
            TableView.Source = datasource;

            this.NavigationItem.Title = "RAy's Meat Lovers";


        }
    
        public override async void HotDogSelected(HotDog selectedHotDog)
        {
            HotDogDetailViewController hotDogDetailViewController = this.Storyboard.InstantiateViewController("hotDogDetailViewController") as HotDogDetailViewController;

            if (hotDogDetailViewController != null)
            {
                hotDogDetailViewController.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;
                hotDogDetailViewController.SelectedHotDog = selectedHotDog;
                await PresentViewControllerAsync(hotDogDetailViewController, true);
            }
        }
    
    
    
    }
}
