using iChef.Models;
using iChef.DAL;
using iChef.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using iChef.DAL.Repositories;

namespace iChef.Services
{
    public class DishService : IDishService
    {
        private IDishRepository dishRepository;
        public DishService(IDishRepository dishRepository)
        {
            this.dishRepository = dishRepository;
        }

        /// <summary>
        /// Get Dish by ID from database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dish GetById(int id)
        {
            return ConvertDTO(dishRepository.GetById(id));
        }

        public Dish ConvertDTO(DishDTO dto)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach(IngredientDTO i in dto.Ingredients)
            {

                ingredients.Add(new Ingredient(i.Name));
            }
            return new Dish(dto.DishName, dto.PreparationTime, ingredients, dto.Preparation);
        }
    }
}
