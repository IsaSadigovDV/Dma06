


using Microsoft.EntityFrameworkCore;
using Relations.Data;
using Relations.Entites.ManyToMany;
using Relations.Entites.OneToMany;
using Relations.Entites.OneToOne;
using static System.Reflection.Metadata.BlobBuilder;

var context = new AppDbContext();




//var citizen2 = new Citizen()
//{
//    Name = "Test2",
//    Surname = "Test2",
//    Passport = new Passport()
//    {
//        Issuer = "asan2",
//        IssuerDate = DateTime.Now,
//    }
//};


//context.Citizens.Add(citizen2);
//context.SaveChanges();





//var category = new Category()
//{
//    Name = "Test",
//};
//var category2 = new Category()
//{
//    Name = "Test2",
//};

//var product = new Product()
//{
//    Name = "test",
//    Description = "Test",
//    Category = category2,
//};

////var product2 = new Product()
////{
////    Name = "test",
////    Description = "Test",
////    Category = category
////};

//context.Categories.Add(category);
//context.Products.Add(product);
//context.SaveChanges();



var author = new Author()
{
    Name = "V.Hugo",
};



var Books = new List<Book>()
    {
        new Book()
        {
            Name = "Sefiller",
           Author = new List<Author>()
           {
               new Author()
               {
                  Name =author.Name,
               }
           } 
        },
        new Book()
        {
            Name = "Noterdam kilsesi",
               Author = new List<Author>()
           {
               new Author()
               {
                  Name =author.Name,
               }
           }
        }
    };

context.Books.AddRange(Books);
context.Authors.Add(author);
context.SaveChanges();


//var passports = context.Passports
//    .Include(x=>x.Citizen)
//    .ToList();

//foreach (var citizen in passports)
//{
//    Console.WriteLine($"{citizen.Issuer} --> {citizen.Citizen.Name}");
//}

//var products = context.Products.Where(p => p.Name == "test").FirstOrDefault();
//var product = context.Products
//    .Include(x=>x.Category)
//    .FirstOrDefault(p => p.CategoryId==4);

//if(product == null )
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Not found");
//    Console.ResetColor();
//}
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"{product.Name}  ||  {product.Category.Name}");
//Console.ResetColor();




