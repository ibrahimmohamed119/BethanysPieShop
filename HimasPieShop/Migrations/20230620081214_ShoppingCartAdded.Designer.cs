﻿// <auto-generated />
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BethanysPieShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230620081214_ShoppingCartAdded")]
    partial class ShoppingCartAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit pies"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cheese cakes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Seasonal pies"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PieId"), 1L, 1);

                    b.Property<string>("AllergyInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "With its flaky, buttery crust; tart-sweet apples, and wonderful cinnamon-y aroma, a slice of our warm apple pie is the perfect end to any repast, from casual lunch to elegant dinner.",
                            PieName = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!"
                        },
                        new
                        {
                            PieId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "To say this Blueberry Cheesecake is bursting with blueberries is an understatement! Baked to achieve that elusive light-yet-rich creamy cheesecake filling, studded with blueberries inside and smothered in an incredible glossy blueberry sauce topping. It’s magnificent!",
                            PieName = "Blueberry Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!"
                        },
                        new
                        {
                            PieId = 3,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "Classic New York-style cheesecake with a buttery graham cracker crust and rich, dense filling made from cream cheese, eggs, sugar, sour cream, vanilla, a hint of lemon, and a few tablespoons of flour.",
                            PieName = "Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "Plain cheese cake. Plain pleasure."
                        },
                        new
                        {
                            PieId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "Nothing says summer like classic cherry pie, and ours is the best cherry pie! Made with fresh, sweet cherries tucked into a double crust, our homemade cherry pie is a delicious classic.",
                            PieName = "Cherry Pie",
                            Price = 15.95m,
                            ShortDescription = "A summer classic!"
                        },
                        new
                        {
                            PieId = 5,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "Dried fruit and a little lemon peel make this double-crust pie extra special for the holidays.",
                            PieName = "Christmas Apple Pie",
                            Price = 13.95m,
                            ShortDescription = "Happy holidays with this pie!"
                        },
                        new
                        {
                            PieId = 6,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "This sweet and tart cranberry pie is the ultimate holiday dessert. A rich, buttery crust is filled with a perfectly tart cranberry filling and topped with a streusel that's deliciously sweet and crumbly!",
                            PieName = "Cranberry Pie",
                            Price = 17.95m,
                            ShortDescription = "A Christmas favorite"
                        },
                        new
                        {
                            PieId = 7,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                            InStock = false,
                            IsPieOfTheWeek = false,
                            LongDescription = "From the buttery flaky pie crust to the juicy cinnamon-spiced peach filling, there’s no doubt this will be the best peach pie you’ll ever eat.",
                            PieName = "Peach Pie",
                            Price = 15.95m,
                            ShortDescription = "Sweet as peach"
                        },
                        new
                        {
                            PieId = 8,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Bursting with flavor, this pumpkin pie is our very favorite. It’s rich, smooth, and tastes incredible on our homemade pie crust and served with whipped cream.",
                            PieName = "Pumpkin Pie",
                            Price = 12.95m,
                            ShortDescription = "Our Halloween favorite"
                        },
                        new
                        {
                            PieId = 9,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Nothing says summer more than rhubarb pie! The filing is intensely pink and sweet tart, encased in a golden pastry crust and sprinkled with a buttery crumble topping. It’s like a rhubarb crisp and pie, all in one! Watching the sun set with a slice of this pie will make all your summer dreams complete.",
                            PieName = "Rhubarb Pie",
                            Price = 15.95m,
                            ShortDescription = "My God, so sweet!"
                        },
                        new
                        {
                            PieId = 10,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "This classic Strawberry Pie is the perfect summer dessert recipe made with an all-butter crust and fresh strawberries.",
                            PieName = "Strawberry Pie",
                            Price = 15.95m,
                            ShortDescription = "Our delicious strawberry pie!"
                        },
                        new
                        {
                            PieId = 11,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                            InStock = false,
                            IsPieOfTheWeek = false,
                            LongDescription = "This Strawberry Cheesecake is a stunner! You’ll love how the sauce slowly drips down the cheesecake with every bite, and how the filling is creamy and rich, but it’s a bit fluffy rather than heavy and dense.",
                            PieName = "Strawberry Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartItemId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("PieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("PieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BethanysPieShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pie");
                });

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Navigation("Pies");
                });
#pragma warning restore 612, 618
        }
    }
}
