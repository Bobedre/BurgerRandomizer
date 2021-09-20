using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeRandomizer
{
     class Recipe
    {
        int[] pageNr = new int[3];

        public Recipe()
        {
            SubRecipe Top = new SubRecipe();
            pageNr[0] = Top.PageNr;

            SubRecipe Mid = new SubRecipe();
            pageNr[1] = Mid.PageNr;

            SubRecipe Bottom = new SubRecipe();
            pageNr[2] = Bottom.PageNr;
        }

        public void PrintRecipe()
        {
             Console.WriteLine($" Top page number : {pageNr[0]} \n Mid page number : {pageNr[1]} \n Bot page number : {pageNr[2]}");
        }
    }
}
