using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    class Controller
    {
        public static void CustomerMenu()
        {
            List<string> DateItems = new List<string>() {
                "Solgt eller Købt",
                "Fremvisning",
                "Tilbage"
            };
            while (true)
            {
                string selectedMenuItem = Menu.drawMenu(DateItems);
                switch (selectedMenuItem)
                {

                    case "Solgt eller Købt":
                        Console.Clear();
                        Database_Controller.InsertCustomer();
                        Console.Clear();
                        Console.WriteLine("Hus tilføjet");
                        Console.WriteLine("");
                        break;
                    case "Fremvisning":
                        Console.Clear();
                        Database_Controller.InsertShowing();
                        break;
                    case "Tilbage":
                        Console.Clear();
                        Menu.DanMenu();
                        break;
                }
            }
        }
        public static void FindMenu()
        {
            List<string> DateItems = new List<string>() {
                "Find via Adresse og PorstNr",
                "Find via Telefonnummer",
                "Tilbage"
            };
                while (true)
                {
                string selectedMenuItem = Menu.drawMenu(DateItems);
                switch (selectedMenuItem)
                {
                    case "Find via Adresse og PorstNr":
                        Console.Clear();
                        Console.WriteLine("Skriv adresse");
                        string add = Console.ReadLine();
                        Console.WriteLine("Skriv Postnummer");
                        string pst = Console.ReadLine();
                        Database_Controller.FindOwnerByAddress(add, pst);
                        break;
                    case "Find via Telefonnummer":
                        Console.Clear();
                        Console.WriteLine("Skriv telefonnummer");
                        string tlf = Console.ReadLine();
                        Database_Controller.FindOwnerByPhone(tlf);
                        break;
                    case "Tilbage":
                        Console.Clear();
                        Menu.DanMenu();
                        break;
                }
            }
        }
    }
}
