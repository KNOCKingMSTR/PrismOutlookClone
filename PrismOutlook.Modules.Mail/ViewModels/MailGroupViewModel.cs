    using Prism.Commands;
    using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismOutlook.Business;

namespace PrismOutlook.Modules.Mail.ViewModels
{
    public class MailGroupViewModel:BindableBase
    {
        public ObservableCollection<NavigationItem> _items;
        private DelegateCommand<object> _selectedCommand;
        public DelegateCommand<object> SelectedCommand =>
            _selectedCommand ??= new DelegateCommand<object>(ExecuteSelectedCommand);

        void ExecuteSelectedCommand(object parameter)
        {
            
        }
        public ObservableCollection<NavigationItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }    
        public MailGroupViewModel()
        {
            GenerateMenu();
        }

        private void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();
            NavigationItem root = new NavigationItem() { Caption = "Personal Folder", NavigationPath = "MailList" };
            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "" });
            root.Items.Add(new NavigationItem() { Caption = "Delete", NavigationPath = "" });
            root.Items.Add(new NavigationItem() { Caption = "Sent", NavigationPath = "" });
            Items.Add(root);
        }


    }
}
