using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ScheduleControlViewModel Schedule 
        {
            get
            {
                return new ScheduleControlViewModel();
            }
        }
    }
}
