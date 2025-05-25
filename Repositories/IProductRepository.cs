using System.Collections.Generic;
using NetTechnicalTest_Template.Models;

namespace NetTechnicalTest_Template.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
