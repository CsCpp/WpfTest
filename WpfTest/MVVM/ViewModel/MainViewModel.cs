using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfTest.Core;

namespace WpfTest.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand ExitApp { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        private object _correntView;

        public object currentView
        {
            get { return _correntView; }
            set { _correntView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
                HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            currentView = HomeVM;
                HomeViewCommand = new RelayCommand(o => 
                { 
                currentView = HomeVM;
                    });

                DiscoveryViewCommand = new RelayCommand(o =>
                {
                    currentView = DiscoveryVM;
                });
            ExitApp = new RelayCommand(o =>
            {
                Environment.Exit(0);
            });
        }
    }
}
