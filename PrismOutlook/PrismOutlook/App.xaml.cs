using System.Windows;

using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using PrismOutlook.Core.Regions;
using PrismOutlook.Modules.Calendar;
using PrismOutlook.Modules.Contacts;
using PrismOutlook.Modules.Mail;
using PrismOutlook.Modules.ModuleName;
using PrismOutlook.Services;
using PrismOutlook.Services.Interfaces;
using PrismOutlook.Views;

namespace PrismOutlook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MailModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<CalendarModule>();
        }
        
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(XamOutlookBar), Container.Resolve<XamOutlookBarRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(XamRibbon), Container.Resolve<XamRibbonRegionAdapter>());

        }
    }
} 

