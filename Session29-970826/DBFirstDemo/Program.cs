using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD
            //CreateRetriveUpdateDelete


            //R
            //var ctx = new AWEntities();

            ////var products = ctx.Products.ToList();
            //var products = ctx.Products
            //    //.Where(p => p.Color == "Red")
            //    //.Where(p => p.ListPrice > 1000)
            //    .Where(p => p.ProductSubcategory.ProductCategory.Name == "Bikes")
            //    .Select(p => p).ToList();
            //    //.Select(p => new { p.ProductID, p.Name, p.Color, p.ListPrice });
            //    //.OrderByDescending(p => p.ListPrice);


            //foreach (var product in products)
            //{
            //    //Console.WriteLine(product);
            //    Console.WriteLine($"{product.ProductID}.{product.Name} : {product.ListPrice:C}");
            //}


            //C
            //EFEntities ctx = new EFEntities();
            //User user = new User()
            //{
            //    Name = "رضا",
            //    Family = "رضایی",
            //    Age = 30
            //};

            //ctx.Users.Add(user);
            //ctx.SaveChanges();

            //U
            //EFEntities ctx = new EFEntities();
            ////var user = ctx.Users.Where(u => u.Id == 1).FirstOrDefault();
            //var user = ctx.Users.Find(1);
            //user.Name = "محسن";
            //user.Family = "محسنی";

            //ctx.SaveChanges();


            //D
            EFEntities ctx = new EFEntities();
            var user = ctx.Users.Find(1);
            ctx.Users.Remove(user);
            ctx.SaveChanges();

            //Console.ReadKey();

        }
    }
}
