using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitsInStock=15, UnitPrice=15 },
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitsInStock=3, UnitPrice=500 },
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitsInStock=2, UnitPrice=1500 },
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitsInStock=65, UnitPrice=150 },
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitsInStock=1, UnitPrice=85 }
            };
        }
        public void Add(Product product)
        {

            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            //Lambda

            //Yontem 1 Foreach ile Gezme
            //Product productToDelete = null;
            //foreach (var item in _products)
            //{
            //    if (product.ProductId==item.ProductId)
            //    {
            //        productToDelete = item;
            //    }
            //}

            //Yontem 2 LINQ ile gezme

            Product productToDelete= _products.SingleOrDefault(item=>item.ProductId==product.ProductId);
            
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(item => item.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //gonderdigim urun id sine sahip olan urunu bul
            Product productToUpdate= _products.SingleOrDefault(item => item.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
