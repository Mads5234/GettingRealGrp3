using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class DateCalc
    {
        public static DateTime FindDate( int months)
        {
            DateTime currentDate;
            currentDate = DateTime.Today;
            DateTime NextDate = currentDate.AddMonths(months);
            return NextDate;
        }
        public static DateTime DateDay(int days)
        {
            DateTime currentDate;
            currentDate = DateTime.Today;
            DateTime NextDate = currentDate.AddDays(days);
            return NextDate;
        }

    }
}

