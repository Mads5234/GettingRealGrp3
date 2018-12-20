using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        private static int index = 0;

        public static void DanMenu()
        {
            List<string> menuItems = new List<string>() {
                "Opret kunde",
                "Find hus og kunde",
                "Afslut"
            };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = drawMenu(menuItems);
                switch(selectedMenuItem)
                    {
                    case "Opret kunde":
                        Console.Clear();
                        Controller.CustomerMenu();
                        break;
                    case "Find hus og kunde":
                        Console.Clear();
                        Controller.FindMenu();
                        break;
                    case "Afslut":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Menu.DanMenu();
                        break;
                    }
            }
        }

        public static string drawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    index = 0; 
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = items.Count - 1;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
    

