using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels.Functions
{
    public static class DateFunctions
    {
        public static DateTime getToday()
        {
            return DateTime.Today;
        }

        public static int getCountOfDaysInMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public static int getCountOfWeeksInMonth(double days)
        {
            double weeks = days / 7;            
            return Convert.ToInt32(Math.Ceiling(weeks));
        }
    }
}
