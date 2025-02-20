using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using PrismOutlook.Core;
using PrismOutlook.Modules.Contacts.Menus;

namespace PrismOutlook.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        private readonly RegionManager _regionManager;

        public ContactsModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}