using Logic.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Logic.ViewModels.Commands
{
    public class BackCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private ScheduleControlViewModel _model;
        public BackCommand(ScheduleControlViewModel model)
        {
            _model = model;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _model.Date = _model.Date.AddMonths(-1);
            _model.update();
        }
    }
}
