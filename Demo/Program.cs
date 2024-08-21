using Demo.Data;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is LINQ
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> OddNumbers = list.Where(Num => Num % 2 == 1).ToList();

            //foreach (int N in OddNumbers)
            //{
            //    Console.Write($"{N}, ");
            //}
            #endregion

            #region LINQ Syntax [Fluent, Query]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Fluent
            //var OddNumbers = Enumerable.Where(Numbers,Num => Num % 2 == 1);

            //foreach (var item in OddNumbers)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region Query
            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;

            //foreach (var Num in OddNumbers)
            //{
            //    Console.Write($"{Num} ");
            //}
            #endregion

            #endregion

            #region Execution Ways

            #region Deferred Execution
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(X => X % 2 == 1);
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, });

            //foreach (var Num in OddNumbers)
            //{
            //    Console.Write($"{Num} "); //1 3 5 7 9 11 13 15 17
            //}

            #endregion

            #region Immediate Execution
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(X => X % 2 == 1).ToList();
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, });

            //foreach (var Num in OddNumbers)
            //{
            //    Console.Write($"{Num} "); //1 3 5 7 9
            //}
            #endregion

            #endregion

            #region Data Setup
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);
            #endregion

            #region Ex01
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //var Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;
            #endregion

            #region Ex02
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //Result = from P in ProductList
            //         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Ex03
            //var Result = ProductList.Where((P,I) => I < 10 && P.UnitsInStock == 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Ex01
            //var Result = ProductList.Select(P => P.ProductName);

            //Result = from P in ProductList
            //         select P.ProductName;
            #endregion

            #region Ex02
            //var Result = CustomerList.Select(C => C.CustomerName);

            //Result = from C in CustomerList
            //         select C.CustomerName;
            #endregion

            #region Ex03
            //var Result = CustomerList.SelectMany((C, I) => C.Orders);

            //var Result = from C in CustomerList
            //             from O in C.Orders
            //             select O;
            #endregion

            #region Ex04
            //var Result = ProductList.Select(P => new {P.ProductID ,P.ProductName });

            //Result = from P in ProductList
            //         select new
            //         {
            //             P.ProductID,
            //             P.ProductName,
            //         }; 
            #endregion

            #region Ex05
            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .Select(P => new
            //                        {
            //                            Id = P.ProductID,
            //                            Name = P.ProductName,
            //                            OldPrice = P.UnitPrice,
            //                            NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //                        });

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             select new
            //             {
            //                 Id = P.ProductID,
            //                 Name = P.ProductName,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //             };
            #endregion

            #region Ex06
            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .Select((P, I) => new
            //                        {
            //                            Index = I,
            //                            Name = P.ProductName,
            //                        });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ex07
            //var Result = ProductList.OrderBy(P => P.UnitPrice);

            //Result = from P in ProductList
            //         orderby P.UnitPrice
            //         select P;


            #endregion

            #region Ex08
            //var Result = ProductList.OrderByDescending(P => P.UnitPrice);

            //Result = from P in ProductList
            //         orderby P.UnitPrice descending
            //         select P; 
            #endregion

            #region Ex09
            //var Result = ProductList.OrderByDescending(P => P.UnitPrice).ThenByDescending(P => P.UnitsInStock).Reverse();
            //Result = from P in ProductList
            //         orderby P.UnitPrice descending, P.UnitsInStock descending
            //         select P; 
            #endregion

            #region Ex10
            //List<Product> ints = new List<Product>();
            //var Result = ProductList.ElementAt(2);
            //Console.WriteLine(Result?.ProductName ?? "Not Found");

            //var Result = (from P in ProductList
            //              where P.UnitsInStock == 0
            //              select new
            //              {
            //                  Name = P.ProductName,
            //                  Id = P.ProductID
            //              }).FirstOrDefault();
            //Console.WriteLine(Result);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            var Result = ProductList.Average(P => P.UnitPrice);

            //var Result = (from P in ProductList
            //             where P.ProductName.Length == MaxLength
            //             select P).First();

            Console.WriteLine(Result);
        }
    }
}
