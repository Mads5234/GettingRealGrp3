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
            int ged = 4;
            string selectedMenuItem = Menu.drawMenu(DateItems);
            switch (selectedMenuItem)
            {
                
                case "Solgt":
                    Console.Clear();
                    Console.WriteLine(DateCalc.FindDate(ged));
                    break;
                case "Købt":
                    DateCalc.FindDate(ged);
                    break;
                case "Fremvisning":
                    DateCalc.FindDate(ged);
                    break;
                case "Tilbage":
                    Menu.DanMenu();
                    break;
            }
        }
    }
}
