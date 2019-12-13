using iChef.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.DAL.DTOs
{
    public class DishDTO : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public List<IngredientDTO> Ingredients { get; set; }
        public string Preparation { get; set; }

        public DishDTO(int id, string name, int preparationTime, List<IngredientDTO> ingredients, string preparation)
        {
            Id = id;
            Name = name;
            PreparationTime = preparationTime;
            Ingredients = ingredients;
            Preparation = preparation;
        }
    }
}
