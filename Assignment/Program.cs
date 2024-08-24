using Assignment.Data;
using System.Collections;
using static Assignment.ListGenerator;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1.Find all products that are out of stock.
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((S, I) => S.Length < I);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 

            //var Result = ProductList.First(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductList.Where(P => P.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine( Result);
            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(A => A > 5).ElementAtOrDefault(1);

            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count(N => N % 2 == 1);

            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var customers = CustomerList.Select(S => new
            //{
            //    Id = S.CustomerID,
            //    Name = S.CustomerName,
            //    Orders = S.Orders.Count(),
            //});

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has

            //var Result = ProductList.GroupBy(G => G.Category).Select(P => new
            //{
            //    CategoryName = P.Key,
            //    Products = P.Count()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();
            //Console.WriteLine(Result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var Result = Words.Sum(W => W.Length);

            //Console.WriteLine(Result);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var Result = Words.Min(W => W.Length);

            //Console.WriteLine(Result);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var Result = Words.Max(W => W.Length);

            //Console.WriteLine(Result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result = Words.Average(W => W.Length);

            //Console.WriteLine(Result);
            #endregion

            #region 9. Get the total units in stock for each product category.

            //var Result = ProductList.GroupBy(G => G.Category)
            //                        .Select(S => new
            //                        {
            //                            Category = S.Key,
            //                            TotalUnitsInStock = S.Sum(M => M.UnitsInStock)
            //                        });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products

            //var Result = ProductList.GroupBy(G => G.Category).Select(S => new
            //{
            //    CategoryName = S.Key,
            //    Cheapest = S.Min(M => M.UnitPrice)
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var Result = from P in ProductList
            //             group P by P.Category
            //             into ProductGroup
            //             let MinPrice = ProductGroup.Min(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = ProductGroup,
            //                 CheapestProducts = ProductGroup.Where(P => P.UnitPrice == MinPrice)
            //             };
            //foreach (var Category in Result)
            //{
            //    Console.Write($"{Category.CategoryName.Key}: ");
            //    foreach (var Product in Category.CheapestProducts)
            //    {
            //        Console.WriteLine($"{Product.ProductName} - {Product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.

            //var Result = ProductList.GroupBy(G => G.Category).Select(S => new
            //{
            //    CategoryName = S.Key,
            //    Cheapest = S.Max(M => M.UnitPrice)
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var Result = ProductList.GroupBy(G => G.Category).Select(S => new
            //{
            //    CategoryName = S.Key,
            //    Cheapest = S.Max(M => M.UnitPrice)
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 14. Get the average price of each category's products.

            //var Result = ProductList.GroupBy(G => G.Category).Select(S => new
            //{
            //    CategoryName = S.Key,
            //    AveragePrice = S.Average(M => M.UnitPrice)
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var Result = from P in ProductList
            //             orderby P.ProductName
            //             select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(A => A, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock).ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A => A);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A => A, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(A => A.Length).ThenByDescending(A => A, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(A => A[1] == 'i').Reverse();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var Result = ProductList.Select(P => P.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] Words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = Words.Select(W => new
            //{
            //    uppercase = W.ToUpper(),
            //    lowercase = W.ToLower(),
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ProductList.Select(P => new
            //{
            //    Name = P.ProductName,
            //    Price = P.UnitPrice,
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((A, I) => new
            //{
            //    Number = A,
            //    InPlace = A == I
            //});
            //Console.WriteLine("Number: In-Place?");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.InPlace}");
            //}
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = from A in numbersA
            //             from B in numbersB
            //             where A < B
            //             select new
            //             {
            //                 A,
            //                 B
            //             };
            //Console.WriteLine("Pairs where a < b: ");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var Result = CustomerList.SelectMany(C => C.Orders).Where(W => W.Total < 500.00M);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var Result = CustomerList.SelectMany(C => C.Orders).Where(W => W.OrderDate.Year >= 1998);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ProductList.Select(P => P.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = ProductList.Select(P => P.ProductName[0]).Union(CustomerList.Select(C => C.CustomerName[0])).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ProductList.Select(P => P.ProductName[0]).Intersect(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ProductList.Select(P => P.ProductName[0]).Except(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Result = ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName[^3..] : P.ProductName)
            //                                     .Concat(CustomerList
            //                                     .Select(C => C.CustomerName.Length >= 3 ? C.CustomerName[^3..] : C.CustomerName));

            //foreach (var chars in Result)
            //{
            //    Console.WriteLine(chars);
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Result = CustomerList.Where(C => C.Region == "WA")
            //                         .SelectMany(C => C.Orders)
            //                         .Take(3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Result = CustomerList.Where(C => C.Region == "WA")
            //                         .SelectMany(C => C.Orders)
            //                         .Skip(2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((n, i) => n >= i);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((n, i) => n >= i);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var Result = Words.Any(W => W.Contains("ei"));
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result = ProductList.GroupBy(P => P.Category).Where(W => W.Any(A => A.UnitsInStock == 0));
            //foreach (var Group in Result)
            //{
            //    Console.WriteLine($"{Group.Key}: ");
            //    foreach (var Product in Group)
            //    {
            //        Console.WriteLine($"- {Product}");
            //    }
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = ProductList.GroupBy(P => P.Category).Where(W => W.All(A => A.UnitsInStock > 0));

            //foreach (var Group in Result)
            //{
            //    Console.WriteLine($"{Group.Key}: ");
            //    foreach (var Product in Group)
            //    {
            //        Console.WriteLine($"- {Product}");
            //    }
            //}
            #endregion
            #endregion

            #region LINQ – Grouping Operators

            #region Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(N => N % 5).OrderBy(G => G.Key);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
            //    foreach (var Number in item)
            //    {
            //        Console.WriteLine(Number);
            //    }
            //}
            #endregion

            #region Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //var Result = Words.GroupBy(W => W[0]).OrderBy(G => G.Key);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var Word in item)
            //    {
            //        Console.WriteLine(Word);
            //    }
            //}
            #endregion

            #region Consider this Array as an Input, Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var Result = Arr.GroupBy(W => new string(W.OrderBy(C => C).ToArray()))
            //                  .Select(group => group.ToList()).ToList();

            //foreach (var item in Result)
            //{
            //    foreach (var Word in item)
            //    {
            //        Console.WriteLine(Word);
            //    }
            //}
            #endregion

            #endregion

        }
    }
}
