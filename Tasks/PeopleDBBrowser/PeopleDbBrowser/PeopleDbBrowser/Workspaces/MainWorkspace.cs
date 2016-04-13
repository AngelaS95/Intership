using Internship.PeopleDbBrowser.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.PeopleDbBrowser.Workspaces
{
    public class MainWorkspace:ViewModelBase
    {
        public bool IsSettingsCommandChecked { get; set; }
        public bool IsImportCommandChecked { get; set; }
        public bool IsSearchCommandChecked { get; set; }
        public RelayCommand SettingsCommand { get; set; }
        public RelayCommand ImportCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }

        ViewModelBase CurrentView { get; set; }

        static bool GetTrue()
        {
            return true;
        }

        public MainWorkspace()
        {

            SettingsCommand = new RelayCommand(() => CurrentView = new DBSettingsViewModel());
            //SettingsCommand = new RelayCommand(() => CurrentView = new importViewModel());
            SearchCommand = new RelayCommand(() => CurrentView = new SearchViewModel());
        }




    }
}
