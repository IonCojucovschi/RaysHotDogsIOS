using System;
using System.Collections.Generic;
using Foundation;
using RaysHotDogs.Core.Model;
using UIKit;

namespace RAysHotDogs.DataSources
{
    public class HotDogDataSources:UITableViewSource
    {


        private List<HotDog> hotDogs;
        NSString cellIdentifier = new NSString("HotDogCell");

        public HotDogDataSources(List<HotDog> hotDogs,UITableViewController callingCOntroller)
        {
            this.hotDogs = hotDogs;
        }



        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;
            if(cell==null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default,cellIdentifier);
            }
            var hotDog = hotDogs[indexPath.Row];
            cell.TextLabel.Text = hotDog.Name;
            cell.ImageView.Image = UIImage.FromFile("Images/" + hotDog.ImagePath + ".jpg");
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hotDogs.Count;
        }
    }
}
