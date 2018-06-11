
using EduxV7.Data;
using EduxV7.Repo;
using System;
using System.Collections.Generic;

namespace EduxV7.Service
{//Veritabanı ilemleri için yani contexti kullanmak yerine bu servisi çağırıp yapıyoruz. 
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public void DeleteProduct(string id)
        {
            Product product = productRepository.Get(id);
            productRepository.Remove(product);
            productRepository.SaveChanges();
        }

        public Product GetProduct(string id)
        {
            return productRepository.Get(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public void InsertProduct(Product product)
        {
            productRepository.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
        }
    }

    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(string id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string id);
    }
}