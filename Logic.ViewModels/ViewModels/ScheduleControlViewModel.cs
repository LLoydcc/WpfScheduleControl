using Logic.ViewModels.Commands;
using Logic.ViewModels.Functions;
using Logic.ViewModels.ViewModels.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Logic.ViewModels.ViewModels
{
    public class ScheduleControlViewModel : ViewModelBase
    {
        private Month _currentMonth;
        private string _dateInformation;
        private DateTime _date;
        public ScheduleControlViewModel()
        {
            Date = DateTime.Today;
            update();
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            this.NextCommand = new NextCommand(this);
            this.BackCommand = new BackCommand(this);
        }
        public ObservableCollection<string> WeekIndications
        {
            get
            {
                return new ObservableCollection<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            }
        }
        public DateTime Date { 
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
        public string DateInformation 
        {
            get
            {
                return _dateInformation;
            }
            set
            {
                _dateInformation = value;
                OnPropertyChanged(nameof(DateInformation));
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
        public void update()
        {
            CurrentMonth = new Month(Date);
            DateInformation = CurrentMonth.Indication + " " + CurrentMonth.Date.Year;
        }
        public ICommand BackCommand { get; set; }
        public ICommand NextCommand { get; set; }
    }
}
