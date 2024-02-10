using System.ComponentModel;

namespace App.Rcsvpg.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel() 
        {
            _name = "BOB?";
            _appTitle = "Tutle?";
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value) return;
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        private string _appTitle;
        public string AppTitle
        {
            get { return _appTitle; }
            set
            {
                if( _appTitle != value) return;
                _appTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AppTitle)));
            }
        }
    }
}
