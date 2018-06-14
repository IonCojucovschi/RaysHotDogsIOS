using System;
using System.Collections.Generic;
using Foundation;
using RaysHotDogs.Core.Model;
using RAysHotDogs.Cells;
using UIKit;
using RaysHotDogs.Core.Service;

namespace RAysHotDogs.DataSources
{
    
    public class HotDogDataSources<T>:UITableViewSource where T : BaseTableCategory
    {
        
        private List<HotDog> hotDogs;
        NSString cellIdentifier = new NSString("HotDogCell");
        T callingController;

        public HotDogDataSources(List<HotDog> hotDogs,T callingCOntroller)
        {
            this.callingController = callingCOntroller;
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
        public HotDog GetItem(int id)
        {
            
            return hotDogs[id];
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

            var selectedHotDog = hotDogs[indexPath.Row];
            callingController.HotDogSelected(selectedHotDog);
            tableView.DeselectRow(indexPath,true);
          
        }
    }
}
