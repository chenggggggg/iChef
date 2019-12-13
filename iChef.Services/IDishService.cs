using iChef.Models;
using System;

namespace iChef.Services
{
    public interface IDishService
    {
        Dish GetById(int id);
    }
}
