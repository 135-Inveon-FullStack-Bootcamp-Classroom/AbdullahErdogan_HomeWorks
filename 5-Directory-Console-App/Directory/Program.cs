using System;
using System.Collections.Generic;
namespace Directory
{
    class Program
    {
        static int indexMainMenu = 0;
        static void Main(string[] args)
        {
            Console.Clear();

            List<string> menuItems = new List<string>()
    {
        "List Directory",
        "Add New Person",
        "Exit"
    };
            DirectoryManager directory = new DirectoryManager();
            List<Person> list;
            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = drawMainMenu(menuItems);
                
                if (selectedMenuItem == "List Directory")
                {
                    list = directory.GetPersonList();
                    if (list.Count>0)
                    {
                        list.ForEach(person => Console.WriteLine(person.Name));
                    }
                    else
                    {
                        Console.WriteLine("No Data");
                    }
                }
                else if (selectedMenuItem == "Add New Person")
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Number: ");
                    string number = Console.ReadLine();
                    Person newPerson = new Person(name, Convert.ToInt64(number));
                    Console.WriteLine(directory.AddNewPerson(newPerson));
                }
                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0); // Or  System.Environment.Exit(0);
                }
            }
        }

        public static string drawMainMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == indexMainMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
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
                if (indexMainMenu == items.Count - 1) { }
                else { indexMainMenu++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (indexMainMenu <= 0) { }
                else { indexMainMenu--; }
            }
            else if (ckey.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
            }
            else if (ckey.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[indexMainMenu];
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
