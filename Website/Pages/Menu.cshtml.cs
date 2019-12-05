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
        public IEnumerable<IMenuItem> Combos { get; set; }

        /// <summary>
        /// List of entrees
        /// </summary>
        public IEnumerable<IMenuItem> Entrees { get; set; }

        /// <summary>
        /// List of sides
        /// </summary>
        public IEnumerable<IMenuItem> Sides { get; set; }

        /// <summary>
        /// List of drinks
        /// </summary>
        public IEnumerable<IMenuItem> Drinks { get; set; }




        /// <summary>
        /// Read only property to access the private menu field
        /// </summary>


        public IEnumerable<IMenuItem> menu;



        /// <summary>
        /// The Get method responses to the server
        /// </summary>
        public void OnGet()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;

            Menu.AllIngredients(Menu.AvailableCombos);
            Menu.AllIngredients(Menu.AvailableEntrees);
            Menu.AllIngredients(Menu.AvailableSides);
            Menu.AllIngredients(Menu.AvailableDrinks);
            Ingre = Menu.PossibleIngredients;
        }

        /// <summary>
        /// The Post method responses to the server
        /// </summary>
        public void OnPost()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;

            Menu.AllIngredients(Menu.AvailableCombos);
            Menu.AllIngredients(Menu.AvailableEntrees);
            Menu.AllIngredients(Menu.AvailableSides);
            Menu.AllIngredients(Menu.AvailableDrinks);
            Ingre = Menu.PossibleIngredients;

            if (search != null)
            {
                Combos = Menu.AvailableCombos.Where(combo => combo.ToString().Contains(search));
                Entrees = Menu.AvailableEntrees.Where(entree => entree.ToString().Contains(search));
                Sides = Menu.AvailableSides.Where(side => side.ToString().Contains(search));
                Drinks = Menu.AvailableDrinks.Where(drink => drink.ToString().Contains(search));
            }

            if(minPrice != null)
            {
                Combos = Menu.AvailableCombos.Where(combo => combo.Price >= minPrice);
                Entrees = Menu.AvailableEntrees.Where(entree => entree.Price >= minPrice);
                Sides = Menu.AvailableSides.Where(side => side.Price >= minPrice);
                Drinks = Menu.AvailableDrinks.Where(drink => drink.Price >= minPrice);
            }

            if(maxPrice != null)
            {
                Combos = Menu.AvailableCombos.Where(combo => combo.Price <= maxPrice);
                Entrees = Menu.AvailableEntrees.Where(entree => entree.Price <= maxPrice);
                Sides = Menu.AvailableSides.Where(side => side.Price <= maxPrice);
                Drinks = Menu.AvailableDrinks.Where(drink => drink.Price <= maxPrice);
            }

            if(ingredients.Count != 0)
            {
                
            }
          
        }
    }
}
