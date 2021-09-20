using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeRandomizer
{
    class Menu
    {
        private bool _running = true;
        List<MenuItem> Items = new List<MenuItem>();
        int menuIndex = 0;
        string Title;

        public Menu(string title)
        {
            Title = title;
        }

        public void Add(MenuItem item)
        {
            Items.Add(item);
        }

        public void Start()
        {
            while(_running)
            {
                Show();
                HandleInput();
            }
        }

        /*
         * Visualzes the menu, by looping through all the items in the list. 
        If the MenuItem at the Selected index is equal to an item it will make an arrow to show which, item is selected in the menu. 
        */
        private void Show()
        {
            Console.Clear();
            foreach (MenuItem item in Items)
            {
                if (SelectedMenuItem == item)
                {
                    Console.Write("-> ");
                }
                Console.WriteLine(item.Title +" "+ item.Content);
            }
        }

        
        //Handles inputs in a Switch case
        public void HandleInput()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.Enter:
                    SelectedMenuItem.Select();
                    break;
                case ConsoleKey.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }

        //Method to get a particular MenuItem in the Items list.
        private MenuItem SelectedMenuItem
        {
            get
            {
                return Items[menuIndex];
            }
        }

        public void MoveDown()
        {
            if (menuIndex == Items.Count-1)
            {
                //Do nothing -- to avoid going out of bounds
            }
            else
            {
                menuIndex++;
            }
        }

        public void MoveUp()
        {
            if (menuIndex == 0)
            {
                //Do nothing -- to avoid going out of bounds
            }
            else
            {
                menuIndex--;
            }
        }

        public void Close()
        {
            _running = false;
        }
    }
}
