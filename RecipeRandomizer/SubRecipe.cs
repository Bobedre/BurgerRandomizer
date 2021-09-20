using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeRandomizer
{
    class SubRecipe
    {

        Random rnd = new Random();

        public int PageNr;
        //public string RecipeText;

        //Generates a random page between 1-30, which can then be looked up in the book.
        public SubRecipe()
        {
            PageNr= rnd.Next(1, 30);
        }
    }
}
