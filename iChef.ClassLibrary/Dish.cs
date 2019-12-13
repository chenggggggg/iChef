using System;
using System.Collections.Generic;

namespace iChef.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Preparation { get; set; }

        public Dish(int id, string name, int preparationTime, List<Ingredient> ingredients, string preparation)
        {
            Id = id;
            Name = name;
            PreparationTime = preparationTime;
            Ingredients = ingredients;
            Preparation = preparation;
        }
    }
}
