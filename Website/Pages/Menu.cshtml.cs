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

        /// <summary>
        /// Bind the search string with cshtml
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// Bind the minimum price with the cshtml
        /// </summary>
        [BindProperty]
        public double? minPrice { get; set; }

        /// <summary>
        /// Bind the maximum price with the cshtml
        /// </summary>
        [BindProperty]
        public double? maxPrice { get; set; }

        /// <summary>
        /// Bind the list of filters with the cshtml
        /// </summary>
        [BindProperty]
        public List<string> filters { get; set; } = new List<string>();

        /// <summary>
        /// Bind the list of ingredients with the cshtml
        /// </summary>
        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        /// <summary>
        /// list of ingredients that are not repeatable
        /// </summary>
        public HashSet<string> Ingre { get; set; } = new HashSet<string>();
 

        /// <summary>
        /// List of combos
        /// </summary>
        public List<IMenuItem> Combos { get; set; }

        /// <summary>
        /// List of entrees
        /// </summary>
        public List<IMenuItem> Entrees { get; set; }

        /// <summary>
        /// List of sides
        /// </summary>
        public List<IMenuItem> Sides { get; set; }

        /// <summary>
        /// List of drinks
        /// </summary>
        public List<IMenuItem> Drinks { get; set; }

        /// <summary>
        /// Read only property to access the private menu field
        /// </summary>
        public Menu Menu { get; } = new Menu();


            
        /// <summary>
        /// The Get method responses to the server
        /// </summary>
        public void OnGet()
        {
            items = Menu.AvailableMenuItems;
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            Menu.AllIngredients(Combos);
            Menu.AllIngredients(Entrees);
            Menu.AllIngredients(Sides);
            Menu.AllIngredients(Drinks);            
            Ingre = Menu.PossibleIngredients;
        }

        /// <summary>
        /// The Post method responses to the server
        /// </summary>
        public void OnPost()
        {
            items = Menu.AvailableMenuItems;
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            Menu.AllIngredients(Combos);
            Menu.AllIngredients(Entrees);
            Menu.AllIngredients(Sides);
            Menu.AllIngredients(Drinks);            
            Ingre = Menu.PossibleIngredients;

            if (search != null)
            {                
                Combos = Menu.Search(Combos, search);
                Entrees = Menu.Search(Entrees, search);
                Sides = Menu.Search(Sides, search);
                Drinks = Menu.Search(Drinks, search);
            }

            if(filters.Count != 0)
            {              
                Combos = Menu.Filter(Combos, filters);
                Entrees = Menu.Filter(Entrees, filters);
                Sides = Menu.Filter(Sides, filters);
                Drinks = Menu.Filter(Drinks, filters);
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
