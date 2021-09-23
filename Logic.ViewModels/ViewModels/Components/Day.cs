using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels.ViewModels.Components
{
    public class Day : ViewModelBase
    {        
        public Day()
        {
            
        }
        public string NumberOfDay { get; set; }
        public DateTime Date { get; set; }
        public bool Inside { get; set; }
    }
}
