using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class DateCalc
    {

        public enum ConcactTime
        {
            Sold = 30,
            Bought = 30,
            Showing = 2,
        }

        public static DateTime FindDates(ConcactTime period)
        {
            DateTime currentDate;
            currentDate = DateTime.Today;
            DateTime NextDate = currentDate.AddDays((int)period - 1);
            return NextDate;
        }

    }
}

