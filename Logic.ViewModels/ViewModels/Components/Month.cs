using Logic.ViewModels.Functions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels.ViewModels.Components
{
    public class Month : ViewModelBase
    {
        private ObservableCollection<Week> _weeks;
        private string _indication;
        private DateTime _date;
        public Month()
        {            
            Indication = MonthIndications[Today.Month - 1];            
        }
        public DateTime Today
        {
            get
            {
                return DateFunctions.getToday();
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        public string Indication
        {
            get
            {
                return _indication;
            }
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }
        public string[] MonthIndications 
        { 
            get
            {
                return new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            } 
        }
        public ObservableCollection<Week> Weeks 
        {
            get
            {
                return _weeks;
            }
            set
            {
                _weeks = value;
                OnPropertyChanged(nameof(Weeks));
            }
        }

        public void update()
        {
                      
        }
    }
}
