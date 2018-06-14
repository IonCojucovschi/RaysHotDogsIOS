using System;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;
using UIKit;

namespace RAysHotDogs
{
    public abstract class BaseTableCategory:UITableViewController
    {
       
        public BaseTableCategory(IntPtr handle) : base(handle)
        {
        }


        public HotDogDetailServices dataService = new HotDogDetailServices();
        public abstract void HotDogSelected(HotDog selectedHotDog);
    }
}
