using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Day1_HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using ExpectedObjects;

namespace TDD_Day1_HomeWork.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        [TestMethod()]
        public void ProductFieldSum_Filed_Cost_PageSize_3_Test()
        {
            //arrange
            IProductDao productDao = new ProductDao();
            ProductService productService = new ProductService(productDao);
            int pageSize = 3;
            var expectd = new int[] { 6, 15, 24, 21 };

            //act
            var actual = productService.ProductGroupsSum(pageSize).Select(f => f.CostTotal);

            //assert
            expectd.ShouldBeEquivalentTo(actual);
        }

        [TestMethod()]
        public void ProductFieldSum_Filed_Revenue_PageSize_4_Test()
        {
            //arrange
            IProductDao productDao = new ProductDao();
            ProductService productService = new ProductService(productDao);
            int pageSize = 4;
            var expectd = new int[] { 50, 66, 60 };

            //act
            var actual = productService.ProductGroupsSum(pageSize).Select(f => f.RevenueTotal);

            //assert
            expectd.ShouldBeEquivalentTo(actual);
        }

        public class ProductDao : IProductDao
        {
            public IEnumerable<Product> GetProducts()
            {
                List<Product> data = new List<Product>();
                data.Add(new Product() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
                data.Add(new Product() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
                data.Add(new Product() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
                data.Add(new Product() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
                data.Add(new Product() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
                data.Add(new Product() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
                data.Add(new Product() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
                data.Add(new Product() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
                data.Add(new Product() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
                data.Add(new Product() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
                data.Add(new Product() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
                return data;
            }
        }
    }
}
