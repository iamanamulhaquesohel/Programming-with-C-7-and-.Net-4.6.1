using Evidence_02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>()
            {
                new Product {ProductID = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, ProductCategoryID = 18, ProductModelID = 9},
                new Product {ProductID = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47, ProductCategoryID = 18, ProductModelID = 9},
                new Product {ProductID = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62, ProductCategoryID = 18, ProductModelID = 9},
                new Product {ProductID = 4, Name = "LL Road Frame - Red, 58", ProductNumber = "FR-R38R-58", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 58, Weight = 1115.83, ProductCategoryID = 18, ProductModelID = 9},
                new Product {ProductID = 5, Name = "LL Road Frame - Red, 60", ProductNumber = "FR-R38R-60", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 60, Weight = 1124.9, ProductCategoryID = 18, ProductModelID = 9},
                new Product {ProductID = 6, Name = "LL Road Frame - Red, 62", ProductNumber = "FR-R38R-62", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 62, Weight = 1133.98, ProductCategoryID = 18, ProductModelID = 9},
                new Product {ProductID = 7, Name = "ML Road Frame - Red, 44", ProductNumber = "FR-R72R-44", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 44, Weight = 1006.97, ProductCategoryID = 18, ProductModelID = 16},
                new Product {ProductID = 8, Name = "ML Road Frame - Red, 48", ProductNumber = "FR-R72R-48", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 48, Weight = 1025.11, ProductCategoryID = 18, ProductModelID = 16},
                new Product {ProductID = 9, Name = "ML Road Frame - Red, 52", ProductNumber = "FR-R72R-52", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 52, Weight = 1043.26, ProductCategoryID = 18, ProductModelID = 16},
                new Product {ProductID = 10, Name = "ML Road Frame - Red, 58", ProductNumber = "FR-R72R-58", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 58, Weight = 1070.47, ProductCategoryID = 18, ProductModelID = 16},
                new Product {ProductID = 11, Name = "ML Road Frame - Red, 60", ProductNumber = "FR-R72R-60", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 60, Weight = 1079.54, ProductCategoryID = 18, ProductModelID = 16},
                new Product {ProductID = 12, Name = "HL Mountain Frame - Silver, 44", ProductNumber = "FR-M94S-44", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 44, Weight = 1251.91, ProductCategoryID = 16, ProductModelID = 5},
                new Product {ProductID = 13, Name = "HL Mountain Frame - Silver, 48", ProductNumber = "FR-M94S-52", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 48, Weight = 1270.05, ProductCategoryID = 16, ProductModelID = 5},
                new Product {ProductID = 14, Name = "HL Mountain Frame - Black, 44", ProductNumber = "FR-M94B-44", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 44, Weight = 1251.91, ProductCategoryID = 16, ProductModelID = 5},
                new Product {ProductID = 15, Name = "HL Mountain Frame - Black, 48", ProductNumber = "FR-M94B-48", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 48, Weight = 1270.05, ProductCategoryID = 16, ProductModelID = 5}
            };

            List<ProductCategory> Categories = new List<ProductCategory>()
            {
                 new ProductCategory {ProductCategoryID = 1, Name = "Bikes"},
                 new ProductCategory {ProductCategoryID = 2, Name = "Components" },
                 new ProductCategory {ProductCategoryID = 3, Name = "Clothing"},
                 new ProductCategory {ProductCategoryID = 4, Name = "Accessories"},
                 new ProductCategory {ProductCategoryID = 5, Name = "Mountain Bikes"},
                 new ProductCategory {ProductCategoryID = 6, Name = "Road Bikes"},
                 new ProductCategory {ProductCategoryID = 7, Name = "Touring Bikes"},
                 new ProductCategory {ProductCategoryID = 8, Name = "Handlebars"},
                 new ProductCategory {ProductCategoryID = 9, Name = "Bottom Brackets"},
                 new ProductCategory {ProductCategoryID = 10, Name = "Brakes"},
                 new ProductCategory {ProductCategoryID = 11, Name = "Chains"},
                 new ProductCategory {ProductCategoryID = 12, Name = "Cranksets"},
                 new ProductCategory {ProductCategoryID = 13, Name = "Derailleurs"},
                 new ProductCategory {ProductCategoryID = 14, Name = "Forks"},
                 new ProductCategory {ProductCategoryID = 15, Name = "Headsets"},
                 new ProductCategory {ProductCategoryID = 16, Name = "Mountain Frames"},
                 new ProductCategory {ProductCategoryID = 17, Name = "Redals"},
                 new ProductCategory {ProductCategoryID = 18, Name = "Road Frames"},
                 new ProductCategory {ProductCategoryID = 19, Name = "saddles"},
                 new ProductCategory {ProductCategoryID = 20, Name = "Touring Frames"},
                 new ProductCategory {ProductCategoryID = 21, Name = "Wheels"},
                 new ProductCategory {ProductCategoryID = 22, Name = "Bib-Shorts"},
                 new ProductCategory {ProductCategoryID = 23, Name = "Caps"},
                 new ProductCategory {ProductCategoryID = 24, Name = "Gloves"},
                 new ProductCategory {ProductCategoryID = 25, Name = "Jerseys"},
                 new ProductCategory {ProductCategoryID = 26, Name = "Shorts"},
                 new ProductCategory {ProductCategoryID = 27, Name = "Socks"},
                 new ProductCategory {ProductCategoryID = 28, Name = "Tights"},
                 new ProductCategory {ProductCategoryID = 29, Name = "Vests"},
                 new ProductCategory {ProductCategoryID = 30, Name = "Bike Racks"},
                 new ProductCategory {ProductCategoryID = 31, Name = "Bike Stands"},
                 new ProductCategory {ProductCategoryID = 32, Name = "Bottles and Cages"},
                 new ProductCategory {ProductCategoryID = 33, Name = "Cleaners"},
                 new ProductCategory {ProductCategoryID = 34, Name = "Fenders"},
                 new ProductCategory {ProductCategoryID = 35, Name = "Helmets"},
                 new ProductCategory {ProductCategoryID = 36, Name = "Hydration Packs"},
                 new ProductCategory {ProductCategoryID = 37, Name = "Lights"},
                 new ProductCategory {ProductCategoryID = 38, Name = "Locks"},
                 new ProductCategory {ProductCategoryID = 39, Name = "Panniers"},
                 new ProductCategory {ProductCategoryID = 40, Name = "Pumps"},
                 new ProductCategory {ProductCategoryID = 41, Name = "Tires and Tubes"}
            };

            List<ProductModel> Models = new List<ProductModel>()
            {
                new ProductModel {ProductModelID = 1, Name = "Classic Vest"},
                new ProductModel {ProductModelID = 2, Name = "Cycling Cap"},
                new ProductModel {ProductModelID = 3, Name = "Full-Finger Gloves"},
                new ProductModel {ProductModelID = 4, Name = "Half-Finger Gloves"},
                new ProductModel {ProductModelID = 5, Name = "HL Mountain Frame"},
                new ProductModel {ProductModelID = 6, Name = "HL Road Frame"},
                new ProductModel {ProductModelID = 7, Name = "HL Touring Frame"},
                new ProductModel {ProductModelID = 8, Name = "LL Mountain Frame"},
                new ProductModel {ProductModelID = 9, Name = "LL Road Frame"},
                new ProductModel {ProductModelID = 10, Name = "LL Touring Frame"},
                new ProductModel {ProductModelID = 11, Name = "Long-Sleeve Logo Jersey"},
                new ProductModel {ProductModelID = 12, Name = "Men's Bib-Shorts"},
                new ProductModel {ProductModelID = 13, Name = "Men's Sports Shorts"},
                new ProductModel {ProductModelID = 13, Name = "Men's Sports Shorts"},
                new ProductModel {ProductModelID = 14, Name = "ML Mountain Frame"},
                new ProductModel {ProductModelID = 15, Name = "ML Mountain Frame-W"},
                new ProductModel {ProductModelID = 16, Name = "ML Road Frame"},
                new ProductModel {ProductModelID = 17, Name = "ML Road Frame-W"},
                new ProductModel {ProductModelID = 18, Name = "Mountain Bike Socks"},
                new ProductModel {ProductModelID = 19, Name = "Mountain-100"}

            };

            //1 Group Product by Model
            Products.GroupBy(p => p.ProductModelID).Select(gr => new { gr.Key, Products = gr }).ToList()
                .ForEach(g =>
                {
                    Console.WriteLine("============================================================");
                    Console.WriteLine("-----------------Group Product by Model:--------------------");
                    Console.WriteLine("============================================================");
                    var model = Models.First(m => m.ProductModelID == g.Key).Name;
                    Console.WriteLine($"Product Model ID: {g.Key}, Product Model Name: {model}");
                    Console.WriteLine("----------------------------------------------------------");
                    foreach (var p in g.Products)
                    {
                        Console.WriteLine($"Product ID: {p.ProductID}, Product Name: {p.Name}, Product Number: {p.ProductNumber}, Product Color: {p.Color}, Product Standard Cost: {p.StandardCost}, Product Price: {p.ListPrice}, Product Size: {p.Size}, Product Weight: {p.Weight}.");
                    }
                });

            //2 Group products by category
            Console.WriteLine();
            Products.GroupBy(c => c.ProductCategoryID).Select(gr => new { gr.Key, Products = gr }).ToList()
               .ForEach(g =>
               {
                   Console.WriteLine("============================================================");
                   Console.WriteLine("-----------------Group Product by Category:-----------------");
                   Console.WriteLine("============================================================");
                   var Category = Categories.First(c => c.ProductCategoryID == g.Key).Name;
                   Console.WriteLine($"Product Model ID: {g.Key}, Product Model Name: {Category}");
                   Console.WriteLine("----------------------------------------------------------");
                   foreach (var p in g.Products)
                   {
                       Console.WriteLine($"Product ID: {p.ProductID}, Product Name: {p.Name}, Product Number: {p.ProductNumber}, Product Color: {p.Color}, Product Standard Cost: {p.StandardCost}, Product Price: {p.ListPrice}, Product Size: {p.Size}, Product Weight: {p.Weight}.");
                   }
               });

            //3 Inner join
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine("------------------Product Inner Join:-----------------------");
            Console.WriteLine("============================================================");
            var InnerSyntex = from p in Products
                              join m in Models on p.ProductModelID equals m.ProductModelID
                              join c in Categories on p.ProductCategoryID equals c.ProductCategoryID
                              select new
                              {
                                  Category = c.Name,
                                  Model = m.Name,
                                  p.Name,
                                  p.ListPrice,
                                  p.Color,
                                  p.Size,
                                  p.Weight
                              };
            foreach (var item in InnerSyntex)
            {
                Console.WriteLine($"Product Name: {item.Name} Category:{item.Category} Model: {item.Model}, Price: {item.ListPrice}, Product Color: {item.Color},Product Size: {item.Size}, Product Weight: {item.Weight}.");
            };

            //4 Left outer join
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine("---------------Product Left Outer Join:---------------------");
            Console.WriteLine("============================================================");
            var LeftOJoinSyntex = from c in Categories
                                  join p in Products on c.ProductCategoryID equals p.ProductCategoryID into cp
                                  from np in cp.DefaultIfEmpty()
                                  select new { Category = c.Name, np?.ProductID, Name = np == null ? "----" : np.Name, np?.ListPrice, np?.Color };
            Console.WriteLine();
            foreach (var item in LeftOJoinSyntex)
            {
                Console.WriteLine($"Product ID: {item.ProductID}, Product Category: {item.Category}, Product Name: {item.Name}, Product Price: {item.ListPrice}, Product Color: {item.Color}.");
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to Exit the Program");
            Console.ReadKey();
        }//Main
    }//Class
}//Namespace

