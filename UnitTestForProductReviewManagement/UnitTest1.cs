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
        [TestMethod]
        public void CheckingTheMethodRetreiveTop3()
        {
            int actual, expected = 3;
            actual = repo.RetrieveTopThreeHighRating(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethodRetreiveParticularRecords()
        {
            int actual, expected = 6;
            actual = repo.RetrieveBasedOnRatingAndProductId(Products);
            Assert.AreEqual(actual, expected);
        }
    }
}
