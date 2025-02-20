using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismOutlook.Business
{
    internal class NavigationItem
    {
        public string Caption { get; set; }

        public string NavigationPath { get; set; }

        public ObservableCollection<NavigationItem> Items { get; set; }     
    }
}
