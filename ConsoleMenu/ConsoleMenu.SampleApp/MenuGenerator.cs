using System;

namespace ConsoleMenu
{
    class MenuGenerator
    {
        public static MenuCollection CreateMenuCollection()
        {
            MenuCollection collection = new MenuCollection();

            return new MenuCollection()
            {
                Menus = {
                    new Menu()
                    {
                      MenuId = 1,
                      MenuItems =
                      {
                        new MenuItem()
                        {
                          Text = "Select Tournaments",
                          Action = () => Console.WriteLine("Tournaments")
                        },
                        new MenuItem()
                        {
                          Text = "Select Players",
                          Action = () => Console.WriteLine("Players")
                        },
                        new MenuItem()
                        {
                          Text = "Select Overall Stats",
                          Action = () => Console.WriteLine("Overall Stats")
                        }
                        }
                    },
                }
            };
        }
    }
}