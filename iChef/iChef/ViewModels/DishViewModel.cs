using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.ViewModels
{
    public class DishViewModel
    {
        public string DishName { get; set; }
        public int PreparationTime { get; set; }
        public List<IngredientViewModel> Ingredients { get; set; }
        public string Preparation { get; set; }

        public DishViewModel(string dishname, int preparationtime, List<IngredientViewModel> ingredients, string preparation)
        {
            this.DishName = dishname;
            this.PreparationTime = preparationtime;
            this.Ingredients = ingredients;
            this.Preparation = preparation;
        }
    }
}
