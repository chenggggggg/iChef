using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.ViewModels
{
    public class IngredientViewModel
    {
        public string IngredientName { get; set; }

        public IngredientViewModel(string ingredientname)
        {
            this.IngredientName = ingredientname;
        }
    }
}
