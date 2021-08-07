using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductRepo
    {
        //Adding Product to list
        public int AddingProductDetailsToList(List<ProductReview> products)
        {
            try
            {
                products.Add(new ProductReview() { productId = 1, userId = 5, review = "Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 10, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 8, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 4, review = "Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 7, isLike = false });
                products.Add(new ProductReview() { productId = 2, userId = 1, review = "Very Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 7, userId = 7, review = "Very Good", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 9, isLike = false });
                products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 9, isLike = true });

                IterateList(products);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products.Count;
        }
        public static void IterateList(List<ProductReview> products)
        {
            try
            {
                foreach (ProductReview i in products)
                {
                    Console.WriteLine($"ProductId:{i.productId}\t UserId:{i.userId}\t Review:{i.review}\t Rating:{i.rating}\t IsLike:{i.isLike}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public int RetrieveTopThreeHighRating(List<ProductReview> products)
        {
            AddingProductDetailsToList(products);
            //Using Linq query sort the list in descending order and take first 3 elements
            var result = (from product in products orderby product.rating descending select product).Take(3).ToList();
            Console.WriteLine("\t\t Top 3 Records Who's Rating Is High ");
            IterateList(result);
            return result.Count;
        }
        public int RetrieveBasedOnRatingAndProductId(List<ProductReview> products)
        {
            AddingProductDetailsToList(products);
            //Using Linq query to retrieve particular product id and rating
            var result = (from product in products where (product.productId == 1 || product.productId == 4 || product.productId == 9) && product.rating > 3 select product).ToList();
            Console.WriteLine("\t\t Retrive Records where ID is 1,4,9 and rating is >3 ");
            IterateList(result);
            return result.Count;
        }
        public int CountOfReviewForEachProductId(List<ProductReview> products)
        {
            int countOfReview = 0;
            AddingProductDetailsToList(products);
            //Using group by in linq
            var result = products.GroupBy(x => x.productId).Select(product => new { productId = product.Key, Count = product.Count() });
            Console.WriteLine("\t\t Count Of Review For Each ProductId ");
            foreach (var product in result)
            {
                Console.WriteLine($"ProductId = {product.productId} | Count={product.Count}\n");
                countOfReview++;
            }
            return countOfReview;
        }
    }
}
