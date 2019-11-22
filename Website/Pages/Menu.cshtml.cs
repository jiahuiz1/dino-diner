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
        Menu menu = new Menu();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }
        /// <summary>
        /// Read only property to access the private menu field
        /// </summary>
        public Menu Menu
        {
            get
            {
                return this.menu;
            }
        }

        /// <summary>
        /// Gets the available combos of the menu
        /// </summary>
        public List<CretaceousCombo> combos
        {
            get
            {
                return Menu.AvailableCombos;
            }
        }

        /// <summary>
        /// Gets the available entrees of the menu
        /// </summary>
        public List<Entree> entrees
        {
            get
            {
                return Menu.AvailableEntrees;
            }
        }

        /// <summary>
        /// Gets the available sides of the menu
        /// </summary>
        public List<Side> sides
        {
            get
            {
                return Menu.AvailableSides;
            }
        }

        /// <summary>
        /// Gets the available drinks of the menu
        /// </summary>
        public List<Drink> drinks
        {
            get
            {
                return Menu.AvailableDrinks;
            }
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if(search != null)
            {
                
            }
        }
    }
}
