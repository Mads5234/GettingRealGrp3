using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    class Controller
    {
        public static void DateMenu()
        {
            List<string> DateItems = new List<string>() {
                "Solgt",
                "Købt",
                "fremvisning",
                "Tilbage"
            };
            string selectedMenuItem = Menu.drawMenu(DateItems);
            switch (selectedMenuItem)
            {
                case "Solgt":
                    Console.Clear();
                    Console.WriteLine(DateCalc.FindDates(DateCalc.ConcactTime.Sold));
                    break;
                case "Købt":
                    DateCalc.FindDates(DateCalc.ConcactTime.Bought);
                    break;
                case "Fremvisning":
                    DateCalc.FindDates(DateCalc.ConcactTime.Showing);
                    break;
                case "Tilbage":
                    Menu.DanMenu();
                    break;
            }
        }
    }
}
