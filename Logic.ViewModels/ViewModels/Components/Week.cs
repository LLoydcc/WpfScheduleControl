using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels.ViewModels.Components
{
    public class Week : ViewModelBase
    {
        public Week()
        {
            Days = new ObservableCollection<Day>();
           
        }            
        public ObservableCollection<Day> Days { get; set; }
        public Day DayOne { get; set; }
        public Day DayTwo { get; set; }
        public Day DayThree { get; set; }
        public Day DayFour { get; set; }
        public Day DayFive { get; set; }
        public Day DaySix { get; set; }
        public Day DaySeven { get; set; }       
        
        public void setDays()
        {
            DayOne = Days[0];
            DayTwo = Days[1];
            DayThree = Days[2];
            DayFour = Days[3];
            DayFive = Days[4];
            DaySix = Days[5];
            DaySeven = Days[6];
        }
    }
}
