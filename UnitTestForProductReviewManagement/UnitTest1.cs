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
        [TestMethod]
        public void CallingAMethodForCountOfReviews()
        {
            int actual, expected = 10;
            actual = repo.CountOfReviewForEachProductId(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodForReturningcountOflist()
        {
            int actual, expected = 20;
            actual = repo.RetriveProductIdAndReviewOnly(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodToSkipTop5AndReturnCount()
        {
            int actual, expected = 15;
            actual = repo.SkipTop5RecordsAndReturnAll(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodForReturningcountoflist()
        {
            int actual, expected = 20;
            actual = repo.RetriveProductIdAndReviewOnlyUsingSelect(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CreatingDataTableAndReturningCountOfRows()
        {
            int actual, expected = 20;
            actual = repo.CreateDataTable(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodToRetriveIfIsLikeIsTrue()
        {
            int actual, expected = 14;
            actual = repo.RetreiveRecordsIfIsLikeTrue(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodToGetAverageRatingOfProductId()
        {
            int actual, expected = 10;
            actual = repo.AverageRatingOfProductId(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodToAllRecordswhoHasGoodRating()
        {
            int actual, expected = 9;
            actual = repo.RetreiveGoodRatings(Products);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CallingAMethodForOrderByForPerticularID()
        {
            int actual, expected = 5;
            actual = repo.RetrieveRecordsOrderbyRating(Products);
            Assert.AreEqual(actual, expected);
        }

    }
}
