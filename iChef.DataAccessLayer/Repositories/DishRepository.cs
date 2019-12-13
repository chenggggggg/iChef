using iChef.DAL.Contexts;
using iChef.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.DAL.Repositories
{
    public class DishRepository : Repository<DishDTO>
    {
        private IDishContext context;

        public DishRepository(IDishContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
