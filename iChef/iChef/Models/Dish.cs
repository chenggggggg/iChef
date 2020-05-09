using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int PreparationTime { get; set; }
        public string Preparation { get; set; }

        public Dish(int id, string name, List<Ingredient> ingredients, int preparationTime, string preparation)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            PreparationTime = preparationTime;
            Preparation = preparation;
        }
    }
}
