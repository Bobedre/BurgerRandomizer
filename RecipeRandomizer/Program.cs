using System;

namespace RecipeRandomizer
{
    class Program
    {
        /*
         A program to make a random burger based on the "Byg din egen burger" a book Liv Martine og Simone Thorup Eriksen. The concept is, 
        that each burger is seperated into 3 categories 1) The bun 2) The burger 3) The salad. This programs allow to randomly select the 3 components required.
         */

        static void Main(string[] args)
        {
            //creates the menu and content
            Menu RecipeRandomizer = new Menu("Menu:");
            RecipeRandomizer.Add(new MenuItem("1:", "Randomize Burger!"));
            RecipeRandomizer.Add(new MenuItem("2:", "Randomize Burger!"));
            RecipeRandomizer.Add(new MenuItem("3:", "Randomize Burger!"));

            RecipeRandomizer.Start();
        }
    }
}
