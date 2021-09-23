using Logic.ViewModels.Functions;
using Logic.ViewModels.ViewModels.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels.ViewModels
{
    public class ScheduleControlViewModel : ViewModelBase
    {
        private Month _currentMonth;
        private string _indicationOfMonth;
        public ScheduleControlViewModel()
        {
            CurrentMonth = new Month();
            NameOfMonth = CurrentMonth.Indication;
        }
        public ObservableCollection<string> WeekIndications
        {
            get
            {
                return new ObservableCollection<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            }
        }
        public string NameOfMonth 
        {
            get
            {
                return _indicationOfMonth;
            }
            set
            {
                _indicationOfMonth = value;
                OnPropertyChanged(nameof(NameOfMonth));
            }
        }
        public Month CurrentMonth 
        {
            get { return _currentMonth; }
            set 
            { 
                _currentMonth = value;
                OnPropertyChanged(nameof(CurrentMonth));
            }
        }
    }
}
