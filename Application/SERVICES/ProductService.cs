using agdata.Application.Interfaces;
using agdata.Domain.Entities.Product; 
using agdata.Infrastructure;
using System;
using System.Collections.Generic;

namespace Services
{
    // Service layer for managing products
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository; // repository to store products

        // Constructor with dependency injection
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository; // inject product repository
        }

        // Create a new product
        public Product CreateProduct(string name, int pointsRequired)
        {
            // Use Product constructor directly (because properties have private setters)
            var p = new Product(name, pointsRequired);

            _productRepository.Add(p); // save product in repository
            return p; // return newly created product
        }

        // Get all products
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll(); // return all stored products
        }

        // Get product by ID
        public Product GetProductById(Guid id)
        {
            var p = _productRepository.GetById(id); // find product by ID
            if (p == null) throw new Exception("Product not found"); // throw error if missing
            return p; // return found product
        }
    }
}
