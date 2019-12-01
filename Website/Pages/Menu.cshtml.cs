using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    /// <summary>
    /// MenuPage class
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// private field to store the menu object
        /// </summary>
       

        public List<IMenuItem> items;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public double? minPrice { get; set; }

        [BindProperty]
        public double? maxPrice { get; set; }

        [BindProperty]
        public List<string> filters { get; set; } = new List<string>();

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();


        public List<IMenuItem> Combos { get; set; }

        public List<IMenuItem> Entrees { get; set; }

        public List<IMenuItem> Sides { get; set; }

        public List<IMenuItem> Drinks { get; set; }

        /// <summary>
        /// Read only property to access the private menu field
        /// </summary>
        public Menu Menu { get; } = new Menu();


            

        public void OnGet()
        {
            items = Menu.AvailableMenuItems;
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
        }

        public void OnPost()
        {
            items = Menu.AvailableMenuItems;
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;

            if (search != null)
            {                
                Combos = Menu.Search(Combos, search);
                Entrees = Menu.Search(Entrees, search);
                Sides = Menu.Search(Sides, search);
                Drinks = Menu.Search(Drinks, search);
            }

            if(filters.Count != 0 && search != null)
            {
               
                Combos = Menu.SearchAndFilter(Combos, filters, search);
                Entrees = Menu.SearchAndFilter(Entrees, filters, search);
                Sides = Menu.SearchAndFilter(Sides, filters, search);
                Drinks = Menu.SearchAndFilter(Drinks, filters, search);
            }

            if(minPrice != null)
            {               
                Combos = Menu.FilterByMinPrice(Combos, minPrice);
                Entrees = Menu.FilterByMinPrice(Entrees, minPrice);
                Sides = Menu.FilterByMinPrice(Sides, minPrice);
                Drinks = Menu.FilterByMinPrice(Drinks, minPrice);
            }

            if(maxPrice != null)
            {
                Combos = Menu.FilterByMaxPrice(Combos, maxPrice);
                Entrees = Menu.FilterByMaxPrice(Entrees, maxPrice);
                Sides = Menu.FilterByMaxPrice(Sides, maxPrice);
                Drinks = Menu.FilterByMaxPrice(Drinks, maxPrice);
            }

            if(ingredients.Count != 0)
            {
                Combos = Menu.FilterByIngredients(Combos, ingredients);
                Entrees = Menu.FilterByIngredients(Entrees, ingredients);
                Sides = Menu.FilterByIngredients(Sides, ingredients);
                Drinks = Menu.FilterByIngredients(Drinks, ingredients);
            }
        }
    }
}
