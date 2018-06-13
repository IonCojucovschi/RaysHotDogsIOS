using System;
using System.Collections.Generic;
using Foundation;
using RaysHotDogs.Core.Model;
using RAysHotDogs.Cells;
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
            HotDogListCell cell = tableView.DequeueReusableCell(cellIdentifier) as HotDogListCell;

            if (cell == null)
                cell = new HotDogListCell(cellIdentifier);
            
            cell.UpdateCell(hotDogs[indexPath.Row].Name
                            , hotDogs[indexPath.Row].Price.ToString()
                            , UIImage.FromFile("Images/"+hotDogs[indexPath.Row].ImagePath+".jpg"));

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hotDogs.Count;
        }
    }
}
