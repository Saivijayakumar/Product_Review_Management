using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System;
using System.Collections.Generic;

namespace UnitTestForProductReviewManagement
{
    [TestClass]
    public class UnitTest1
    {
        ProductRepo  repo;
        List<ProductReview> Products;

        [TestInitialize]
        public void SetUp()
        {
            Products = new List<ProductReview>();
            repo = new ProductRepo();
        }
        [TestMethod]
        public void AddingDataToListAndReturnTheCount()
        {
            int actual, expected = 20;
            actual = repo.AddingProductDetailsToList(Products);
            Assert.AreEqual(actual, expected);
        }
    }
}
