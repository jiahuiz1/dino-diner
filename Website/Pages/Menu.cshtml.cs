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
                Combos = Combos.Where(combo => combo.ToString().Contains(search));
                Entrees = Entrees.Where(entree => entree.ToString().Contains(search));
                Sides = Sides.Where(side => side.ToString().Contains(search));
                Drinks = Drinks.Where(drink => drink.ToString().Contains(search));
            }

            if(filters.Count != 0)
            {
                Combos = Combos.Where(combo => combo is CretaceousCombo && filters.Contains("Combo"));
                Entrees = Entrees.Where(entree => entree is Entree && filters.Contains("Entree"));
                Sides = Sides.Where(side => side is Side && filters.Contains("Side"));
                Drinks = Drinks.Where(drink => drink is Drink && filters.Contains("Drink"));
            }

            if(minPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price >= minPrice);
                Entrees = Entrees.Where(entree => entree.Price >= minPrice);
                Sides = Sides.Where(side => side.Price >= minPrice);
                Drinks = Drinks.Where(drink => drink.Price >= minPrice);
            }

            if(maxPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price <= maxPrice);
                Entrees = Entrees.Where(entree => entree.Price <= maxPrice);
                Sides = Sides.Where(side => side.Price <= maxPrice);
                Drinks = Drinks.Where(drink => drink.Price <= maxPrice);
            }
            

            if(ingredients.Count != 0)
            {

                Combos = Combos.Where(combo =>
                {
                    List<IMenuItem> results = new List<IMenuItem>();
                    bool safeToAdd = true;
                    for (int j = 0; j < ingredients.Count; j++)
                    {
                        if (combo.Ingredients.Contains(ingredients[j]))
                        {
                            safeToAdd = false;
                            break;
                        }
                    }
                    return safeToAdd;                   
                });

                Entrees = Entrees.Where(entree =>
                {
                    List<IMenuItem> results = new List<IMenuItem>();
                    bool safeToAdd = true;
                    for (int j = 0; j < ingredients.Count; j++)
                    {
                        if (entree.Ingredients.Contains(ingredients[j]))
                        {
                            safeToAdd = false;
                            break;
                        }
                    }
                    return safeToAdd;
                });

                Sides = Sides.Where(side =>
                {
                    List<IMenuItem> results = new List<IMenuItem>();
                    bool safeToAdd = true;
                    for (int j = 0; j < ingredients.Count; j++)
                    {
                        if (side.Ingredients.Contains(ingredients[j]))
                        {
                            safeToAdd = false;
                            break;
                        }
                    }
                    return safeToAdd;
                });

                Drinks = Drinks.Where(drink =>
                {
                    List<IMenuItem> results = new List<IMenuItem>();
                    bool safeToAdd = true;
                    for (int j = 0; j < ingredients.Count; j++)
                    {
                        if (drink.Ingredients.Contains(ingredients[j]))
                        {
                            safeToAdd = false;
                            break;
                        }
                    }
                    return safeToAdd;
                });
            }
          
        }
    }
}
