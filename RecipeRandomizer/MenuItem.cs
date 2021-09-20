using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeRandomizer
{
    class MenuItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
        Recipe Burger = new Recipe();

        public MenuItem(string title, string content)
        {
            Title = title;
            Content = content;
        }


        //Method for when a MenuItem has been selected in the Menu
        public void Select()
        {
            Console.Clear();
            Burger.PrintRecipe();
            Console.WriteLine("......");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }
    }
}
