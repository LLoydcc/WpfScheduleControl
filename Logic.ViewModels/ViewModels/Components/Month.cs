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
        public Month()
        {
            Weeks = new ObservableCollection<Week>();
            Indication = "JUNI";
            for (int i = 0; i < 4; i++)
            {
                Week week = new Week();
                Weeks.Add(week);
            }
        }
        public string Indication { get; set; }
        public ObservableCollection<Week> Weeks { get; set; }
    }
}
