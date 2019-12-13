using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Ingredient(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
