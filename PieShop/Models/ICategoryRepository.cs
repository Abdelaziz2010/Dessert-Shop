using System;
using System.Collections.Generic;
using System.Linq;
namespace PieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
