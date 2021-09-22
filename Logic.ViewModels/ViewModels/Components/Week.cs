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
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                day.NumberOfDay = i.ToString();
                Days.Add(day);
            }
        }
        public ObservableCollection<Day> Days { get; set; }
    }

}
