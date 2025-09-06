using DbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindBbContext context = new NorthwindBbContext();
            #region DatabaseFirst
            //using NorthWindDbContext context = new NorthWindDbContext();
            //context.Products.ToList();
            //foreach (var product in context.Products)
            //{
            //    Console.WriteLine(product.ProductName);
            //} 
            #endregion

            #region Run Sql
            #region DQL
            //var Result = context.Products.FromSqlRaw("select * from Products Where CategoryId = 1");
            //var CatId = 1;
            //Result = context.Products.FromSqlRaw("select * From Products Where CategoryId = {0}", CatId);
            //Result = context.Products.FromSqlInterpolated($"select * From Products Where CategoryId = {CatId}");

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //} 
            #endregion

            #region DML
            //var Result = context.Database.ExecuteSqlRaw("Update Products Set productName='Test' Where ProductID=89");
            //Console.WriteLine(Result);
            //int ProductID = 89;
            //Result = context.Database.ExecuteSqlRaw("Update Products Set productName='Test' Where ProductID={0}",ProductID);
            //Result = context.Database.ExecuteSqlInterpolated($"Update Products Set productName='Test' Where ProductID={ProductID}");
            //Console.WriteLine(Result);

            #endregion
            #endregion

            #region Stored Procedures
            //NorthwindBbContextProcedures procedures = new NorthwindBbContextProcedures(context);
            #region Exam01
            //var Result = procedures.CustOrderHistAsync("ALFKI").Result;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Exam02
            //var Result = context.Procedures.DeleteEmployeeByIDAsync(93).Result;
            //Console.WriteLine(Result);

            #endregion
            #endregion

            #region Views
            //var Result = context.SalesTotalsByAmounts.ToList();
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result.CompanyName);
            //}
            #endregion


        }
    }
}
