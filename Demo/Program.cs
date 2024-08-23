using Demo.Data;
using System.Collections;
using static Demo.ListGenerator;
using System.Text.RegularExpressions;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Session 01
            //#region What is LINQ
            ////List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////List<int> OddNumbers = list.Where(Num => Num % 2 == 1).ToList();

            ////foreach (int N in OddNumbers)
            ////{
            ////    Console.Write($"{N}, ");
            ////}
            //#endregion

            //#region LINQ Syntax [Fluent, Query]

            ////List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //#region Fluent
            ////var OddNumbers = Enumerable.Where(Numbers,Num => Num % 2 == 1);

            ////foreach (var item in OddNumbers)
            ////{
            ////    Console.Write($"{item} ");
            ////} 
            //#endregion

            //#region Query
            ////var OddNumbers = from N in Numbers
            ////                 where N % 2 == 1
            ////                 select N;

            ////foreach (var Num in OddNumbers)
            ////{
            ////    Console.Write($"{Num} ");
            ////}
            //#endregion

            //#endregion

            //#region Execution Ways

            //#region Deferred Execution
            ////List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////var OddNumbers = Numbers.Where(X => X % 2 == 1);
            ////Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, });

            ////foreach (var Num in OddNumbers)
            ////{
            ////    Console.Write($"{Num} "); //1 3 5 7 9 11 13 15 17
            ////}

            //#endregion

            //#region Immediate Execution
            ////List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////var OddNumbers = Numbers.Where(X => X % 2 == 1).ToList();
            ////Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, });

            ////foreach (var Num in OddNumbers)
            ////{
            ////    Console.Write($"{Num} "); //1 3 5 7 9
            ////}
            //#endregion

            //#endregion

            //#region Data Setup
            ////Console.WriteLine(ProductList[0]);
            ////Console.WriteLine(CustomerList[0]);
            //#endregion

            //#region Ex01
            ////var Result = ProductList.Where(P => P.UnitsInStock == 0);

            ////var Result = from P in ProductList
            ////         where P.UnitsInStock == 0
            ////         select P;
            //#endregion

            //#region Ex02
            ////var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            ////Result = from P in ProductList
            ////         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            ////         select P;

            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            //#endregion

            //#region Ex03
            ////var Result = ProductList.Where((P,I) => I < 10 && P.UnitsInStock == 0);

            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            //#endregion

            //#region Ex01
            ////var Result = ProductList.Select(P => P.ProductName);

            ////Result = from P in ProductList
            ////         select P.ProductName;
            //#endregion

            //#region Ex02
            ////var Result = CustomerList.Select(C => C.CustomerName);

            ////Result = from C in CustomerList
            ////         select C.CustomerName;
            //#endregion

            //#region Ex03
            ////var Result = CustomerList.SelectMany((C, I) => C.Orders);

            ////var Result = from C in CustomerList
            ////             from O in C.Orders
            ////             select O;
            //#endregion

            //#region Ex04
            ////var Result = ProductList.Select(P => new {P.ProductID ,P.ProductName });

            ////Result = from P in ProductList
            ////         select new
            ////         {
            ////             P.ProductID,
            ////             P.ProductName,
            ////         }; 
            //#endregion

            //#region Ex05
            ////var Result = ProductList.Where(P => P.UnitsInStock > 0)
            ////                        .Select(P => new
            ////                        {
            ////                            Id = P.ProductID,
            ////                            Name = P.ProductName,
            ////                            OldPrice = P.UnitPrice,
            ////                            NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            ////                        });

            ////var Result = from P in ProductList
            ////             where P.UnitsInStock > 0
            ////             select new
            ////             {
            ////                 Id = P.ProductID,
            ////                 Name = P.ProductName,
            ////                 OldPrice = P.UnitPrice,
            ////                 NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            ////             };
            //#endregion

            //#region Ex06
            ////var Result = ProductList.Where(P => P.UnitsInStock > 0)
            ////                        .Select((P, I) => new
            ////                        {
            ////                            Index = I,
            ////                            Name = P.ProductName,
            ////                        });

            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //#endregion

            //#region Ex07
            ////var Result = ProductList.OrderBy(P => P.UnitPrice);

            ////Result = from P in ProductList
            ////         orderby P.UnitPrice
            ////         select P;


            //#endregion

            //#region Ex08
            ////var Result = ProductList.OrderByDescending(P => P.UnitPrice);

            ////Result = from P in ProductList
            ////         orderby P.UnitPrice descending
            ////         select P; 
            //#endregion

            //#region Ex09
            ////var Result = ProductList.OrderByDescending(P => P.UnitPrice).ThenByDescending(P => P.UnitsInStock).Reverse();
            ////Result = from P in ProductList
            ////         orderby P.UnitPrice descending, P.UnitsInStock descending
            ////         select P; 
            //#endregion

            //#region Ex10
            ////List<Product> ints = new List<Product>();
            ////var Result = ProductList.ElementAt(2);
            ////Console.WriteLine(Result?.ProductName ?? "Not Found");

            ////var Result = (from P in ProductList
            ////              where P.UnitsInStock == 0
            ////              select new
            ////              {
            ////                  Name = P.ProductName,
            ////                  Id = P.ProductID
            ////              }).FirstOrDefault();
            ////Console.WriteLine(Result);
            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //#endregion

            //var Result = ProductList.Average(P => P.UnitPrice);

            ////var Result = (from P in ProductList
            ////             where P.ProductName.Length == MaxLength
            ////             select P).First();

            //Console.WriteLine(Result); 
            #endregion

            #region Casting Operators
            ////List<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            ////Product[] Result = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            ////Dictionary<long, Product> Result = ProductList.Where(P => P.UnitsInStock == 0)
            ////                                              .ToDictionary(P => P.ProductID);

            ////Dictionary<long, string> Result = ProductList.Where(P => P.UnitsInStock == 0)
            ////                                             .ToDictionary(P => P.ProductID , P => P.ProductName);

            ////HashSet<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            ////ArrayList Obj = new ArrayList()
            ////{
            ////    "Mohamed",
            ////    "Ahmed",
            ////    "Ali",
            ////    1,
            ////    2,
            ////    3,
            ////    4,
            ////    5
            ////};
            ////var Result = Obj.OfType<int>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generation Operators
            ////var Result = Enumerable.Range(0, 50);

            ////var Result = Enumerable.Repeat(new Product(), 10);

            //var Result = Enumerable.Empty<Product>().ToArray();
            //Product[] products = new Product[0];

            //var Result02 = Enumerable.Empty<Product>().ToList();
            //List<Product> products02 = new List<Product>();


            //foreach (var item in Result02)
            //    {
            //        Console.Write($"{item} ");
            //    } 
            #endregion

            #region Set Operators
            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var Result = Seq01.Union(Seq02);

            //Result = Seq01.Concat(Seq02);

            //Result = Seq01.Distinct();

            //Result = Seq01.Intersect(Seq02);

            //Result = Seq01.Except(Seq02);

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Quentifier Operators
            //var Result = ProductList.Any(P => P.UnitsInStock == 2);

            //Result = ProductList.All(P => P.UnitsInStock > 0);

            //Console.WriteLine(Result);
            #endregion

            #region Zipping Operator
            //string[] Names = { "Mohamed", "Osama", "Ali" };
            //int[] Numbers = Enumerable.Range(0, 10).ToArray();
            //char[] Chars = { 'a', 'b', 'c', 'd' };

            ////var Result = Names.Zip(Numbers);

            ////var Result = Names.Zip(Numbers, (Name, Number) => new { Index = Number, Name });

            //var Result = Names.Zip(Numbers, Chars);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Grouping Operators
            //var Result = from P in ProductList
            //             group P by P.Category;

            //var Result = ProductList.GroupBy(P => P.Category);

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category);

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category;

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select Category;

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .Where(P => P.Count() > 10);

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .Where(C => C.Count() > 10)
            //                        .Select(S => new
            //                        {
            //                            Name = S.Key,
            //                            Count = S.Count()
            //                        });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"          {product.ProductName}");
            //    }

            #endregion

            #region Partioning Operators
            //var Result = ProductList.Take(10);
            //Result = ProductList.TakeLast(10);

            //var Result = ProductList.Skip(10).Take(10);

            //var Result = ProductList.TakeWhile(P => P.UnitPrice > 20M);

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var Result = Numbers.SkipWhile(Num => Num % 3 != 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Let and Into
            //List<string> Numbers = new List<string>() { "Mohamed", "Osama", "Ali", "Omar" };

            //var Result = from N in Numbers
            //             select Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //             into NoVowelNames
            //             where NoVowelNames.Length > 3
            //             select NoVowelNames;

            //Result = from N in Numbers
            //         let NoVowelNames = Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //         where NoVowelNames.Length > 3
            //         select NoVowelNames;


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}

