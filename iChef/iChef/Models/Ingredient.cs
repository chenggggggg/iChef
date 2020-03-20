using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Models
{
    public class Ingredient
    {
        public string Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
