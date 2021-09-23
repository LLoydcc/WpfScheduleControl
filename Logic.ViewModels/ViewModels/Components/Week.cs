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
                 
        }
        public ObservableCollection<Day> Days { get; set; }    
    }
}
