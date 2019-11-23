using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The Menu class
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Return all MenuItem Items as a list
        /// </summary>
        public List<IMenuItem> AvailableMenuItems {
            get {
                List<IMenuItem> list = new List<IMenuItem>();
                list.AddRange(AvailableEntrees);
                list.AddRange(AvailableDrinks);
                list.AddRange(AvailableSides);
                list.AddRange(AvailableCombos);              
                return list;
            }
        }

        /// <summary>
        /// Return all available entrees as a list 
        /// </summary>
        public List<IMenuItem> AvailableEntrees {
            get {
                List<IMenuItem> ingredients = new List<IMenuItem>();
                Brontowurst bt = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burger = new SteakosaurusBurger();
                TRexKingBurger trkb = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();

                ingredients.Add(bt);
                ingredients.Add(dn);
                ingredients.Add(pbj);
                ingredients.Add(wings);
                ingredients.Add(burger);
                ingredients.Add(trkb);
                ingredients.Add(wrap);

                return ingredients;
            }
        }

        /// <summary>
        /// Return all available sides as a list
        /// </summary>
        public List<IMenuItem> AvailableSides {
            get {
                List<IMenuItem> list = new List<IMenuItem>();
                Fryceritops ff = new Fryceritops();
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                Triceritots tt = new Triceritots();
                MezzorellaSticks ms = new MezzorellaSticks();
                list.Add(ff);
                list.Add(mmc);
                list.Add(tt);
                list.Add(ms);

                return list;
            }
        }

        /// <summary>
        /// Return all available drinks as a list
        /// </summary>
        public List<IMenuItem> AvailableDrinks {
            get {
                List<IMenuItem> list = new List<IMenuItem>();
                Sodasaurus ss = new Sodasaurus();
                Tyrannotea ttea = new Tyrannotea();
                JurassicJava jj = new JurassicJava();
                Water water = new Water();
                list.Add(ss);
                list.Add(ttea);
                list.Add(jj);
                list.Add(water);

                return list;
            }
        }

        /// <summary>
        /// Return all available combos as a list
        /// </summary>
        public List<IMenuItem> AvailableCombos {
            get {
                List<IMenuItem> ingredients = new List<IMenuItem>();
                Brontowurst bt = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burger = new SteakosaurusBurger();
                TRexKingBurger trkb = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();


                CretaceousCombo c1 = new CretaceousCombo(bt);
                CretaceousCombo c2 = new CretaceousCombo(dn);
                CretaceousCombo c3 = new CretaceousCombo(pbj);
                CretaceousCombo c4 = new CretaceousCombo(wings);
                CretaceousCombo c5 = new CretaceousCombo(burger);
                CretaceousCombo c6 = new CretaceousCombo(trkb);
                CretaceousCombo c7 = new CretaceousCombo(wrap);

                ingredients.Add(c1);
                ingredients.Add(c2);
                ingredients.Add(c3);
                ingredients.Add(c4);
                ingredients.Add(c5);
                ingredients.Add(c6);
                ingredients.Add(c7);

                return ingredients;

            }
        }

        public string PossibleIngredients { get; set; }




        /// <summary>
        /// override the ToString() method that contains the string of all MenuItems
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(object item in this.AvailableMenuItems)
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public List<IMenuItem> Search(List<IMenuItem> menus, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach(IMenuItem item in menus)
            {
                //check this if only have one parameter
                if (item.ToString().Contains(searchString))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        //how to check if the menuitem is a category. if do nested foreach, there could be duplicate
        public List<IMenuItem> SearchAndFilter(List<IMenuItem> menus, List<string> categories, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            
            foreach (IMenuItem item in menus)
            {
                if (item is CretaceousCombo && categories.Contains("Combo") && item.ToString().Contains(searchString))
                {
                    result.Add(item);
                }
                if(item is Entree && categories.Contains("Entree") && item.ToString().Contains(searchString))
                {
                    result.Add(item);
                }
                if (item is Side && categories.Contains("Side") && item.ToString().Contains(searchString))
                {
                    result.Add(item);
                }
                if (item is Drink && categories.Contains("Drink") && item.ToString().Contains(searchString))
                {
                    result.Add(item);
                }               
            }

            return result;
        }

        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> menus, float? minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem item in menus)
            {
                if(item.Price >= minPrice)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menus, float? maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menus)
            {
                if (item.Price <= maxPrice)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}
