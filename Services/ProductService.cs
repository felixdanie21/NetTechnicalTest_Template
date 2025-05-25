using System.Collections.Generic;
using NetTechnicalTest_Template.Models;
using NetTechnicalTest_Template.Repositories;

namespace NetTechnicalTest_Template.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetProducts();
        }
    }
}
