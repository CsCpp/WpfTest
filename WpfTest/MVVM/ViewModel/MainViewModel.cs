using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Core;

namespace WpfTest.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVM { get; set; }
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
            currentView = HomeVM;
        }
    }
}
