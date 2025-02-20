using Infragistics.Windows.OutlookBar;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using PrismOutlook.Core;
using PrismOutlook.Modules.Calendar.Menus;
using PrismOutlook.Modules.Calendar.Views;

namespace PrismOutlook.Modules.Calendar
{
    public class CalendarModule : IModule
    {
        private readonly RegionManager _regionManager;
        public CalendarModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(CalendarGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}