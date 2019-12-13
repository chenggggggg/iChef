using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.DAL.DTOs
{
    public class IngredientDTO : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IngredientDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
