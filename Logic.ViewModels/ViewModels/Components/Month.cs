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
        public Month(DateTime date)
        {
            Date = date;
            Indication = MonthIndications[Date.Month - 1];
            Weeks = new ObservableCollection<Week>();
            update();
        }
        public Week WeekOne { get; set; }
        public Week WeekTwo { get; set; }
        public Week WeekThree { get; set; }
        public Week WeekFour { get; set; }
        public Week WeekFive { get; set; }
        public Week WeekSix { get; set; }
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Month));
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
        
        /// <summary>
        /// initializes the calendar and fills viewmodels
        /// </summary>
        public void update()
        {
            DateTime sDate = new DateTime(Date.Year, Date.Month, 1);             
            /** we need to calculate -1 because the start of the week is always a sunday (index 0). 
             *  But instead we want the week to begin at a monday. 
            */
            int sDay = (int)sDate.DayOfWeek - 1;
            sDate = sDate.AddDays(-sDay);

            DateTime eDate = new DateTime(Date.Year, Date.Month, 1);
            eDate = eDate.AddMonths(1).AddDays(-1);
            int eDay = (int)eDate.DayOfWeek - 1;
            int offset = 6 - eDay;
            eDate = eDate.AddDays(offset);

            double range = (eDate - sDate).TotalDays + 1;

            for(int i = 0; i < (range / 7); i++)
            {
                Week week = new Week();
                for (int j = 0; j < 7; j++)
                {
                    
                    //Day day = new Day();
                    //day.NumberOfDay = sDate.Day.ToString();
                    //day.Date = sDate;
                    week.Days.Add(modify(sDate));
                    sDate = sDate.AddDays(1);

                }
                week.setDays();
                Weeks.Add(week);
            }
            setWeeks();
        }
        private Day modify(DateTime sDate) 
        {
            Day day = new Day();
            day.NumberOfDay = sDate.Day.ToString();
            day.Date = sDate;

            if(sDate.Month != Date.Month)
            {
                day.Inside = false;
            } else
            {
                day.Inside = true;
            }

            return day;
        }
        private void setWeeks()
        {
            WeekOne = Weeks[0];
            WeekTwo = Weeks[1];
            WeekThree = Weeks[2];
            WeekFour = Weeks[3];
            if(Weeks.Count > 4)
            {
                WeekFive = Weeks[4];
            }            
            if(Weeks.Count > 5)
            {
                WeekSix = Weeks[5];
            }
        }
    }
}