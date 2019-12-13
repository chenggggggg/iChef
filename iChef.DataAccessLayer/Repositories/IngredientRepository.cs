using iChef.DAL.Contexts;
using iChef.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.DAL.Repositories
{
    public class IngredientRepository
    {
        private IIngredientContext context;

        public IngredientRepository(IIngredientContext context)
        {
            this.context = context;
        }

        public IngredientDTO GetById(int id)
        {
            return context.Read(id);
        }
    }
}
