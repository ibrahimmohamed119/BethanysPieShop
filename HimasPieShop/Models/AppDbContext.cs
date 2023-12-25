using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies" });

            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, CountryName = "Egypt" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, CountryName = "Canada" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, CountryName = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, CountryName = "Spain" });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                PieName = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                    "With its flaky, buttery crust; tart-sweet apples, and wonderful cinnamon-y aroma, a slice of our warm apple pie is the perfect end to any repast, from casual lunch to elegant dinner.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                PieName = "Blueberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "To say this Blueberry Cheesecake is bursting with blueberries is an understatement! Baked to achieve that elusive light-yet-rich creamy cheesecake filling, studded with blueberries inside and smothered in an incredible glossy blueberry sauce topping. It’s magnificent!",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                PieName = "Cheese Cake",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription =
                    "Classic New York-style cheesecake with a buttery graham cracker crust and rich, dense filling made from cream cheese, eggs, sugar, sour cream, vanilla, a hint of lemon, and a few tablespoons of flour.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                PieName = "Cherry Pie",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                LongDescription =
                    "Nothing says summer like classic cherry pie, and ours is the best cherry pie! Made with fresh, sweet cherries tucked into a double crust, our homemade cherry pie is a delicious classic.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                PieName = "Christmas Apple Pie",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this pie!",
                LongDescription =
                    "Dried fruit and a little lemon peel make this double-crust pie extra special for the holidays.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 6,
                PieName = "Cranberry Pie",
                Price = 17.95M,
                ShortDescription = "A Christmas favorite",
                LongDescription =
                    "This sweet and tart cranberry pie is the ultimate holiday dessert. A rich, buttery crust is filled with a perfectly tart cranberry filling and topped with a streusel that's deliciously sweet and crumbly!",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 7,
                PieName = "Peach Pie",
                Price = 15.95M,
                ShortDescription = "Sweet as peach",
                LongDescription =
                    "From the buttery flaky pie crust to the juicy cinnamon-spiced peach filling, there’s no doubt this will be the best peach pie you’ll ever eat.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 8,
                PieName = "Pumpkin Pie",
                Price = 12.95M,
                ShortDescription = "Our Halloween favorite",
                LongDescription =
                    "Bursting with flavor, this pumpkin pie is our very favorite. It’s rich, smooth, and tastes incredible on our homemade pie crust and served with whipped cream.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 9,
                PieName = "Rhubarb Pie",
                Price = 15.95M,
                ShortDescription = "My God, so sweet!",
                LongDescription =
                    "Nothing says summer more than rhubarb pie! The filing is intensely pink and sweet tart, encased in a golden pastry crust and sprinkled with a buttery crumble topping. It’s like a rhubarb crisp and pie, all in one! Watching the sun set with a slice of this pie will make all your summer dreams complete.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 10,
                PieName = "Strawberry Pie",
                Price = 15.95M,
                ShortDescription = "Our delicious strawberry pie!",
                LongDescription =
                    "This classic Strawberry Pie is the perfect summer dessert recipe made with an all-butter crust and fresh strawberries.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 11,
                PieName = "Strawberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "This Strawberry Cheesecake is a stunner! You’ll love how the sauce slowly drips down the cheesecake with every bite, and how the filling is creamy and rich, but it’s a bit fluffy rather than heavy and dense.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });
        }
    }
}
