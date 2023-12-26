using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.WebAPI.src.Database
{
    public class SeedData
    {
        private static PasswordHasher _passwordHasher = new();

        // User GUID
        public static readonly Guid AdminUserGuid = Guid.Parse("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab");
        public static readonly Guid User1Guid = Guid.Parse("760454fa-4af1-4ae6-9b18-ed3aec4be2a9");
        public static readonly Guid User2Guid = Guid.Parse("611a0192-8b2e-4997-a8c8-59b93674d33b");

        // // Categories GUID
        public static readonly Guid Category1Guid = Guid.Parse("88499694-269b-4308-a64d-0e903a1f503d");
        public static readonly Guid Category2Guid = Guid.Parse("23b984f8-26f7-49a5-82ea-f4f5ddd16eca");
        public static readonly Guid Category3Guid = Guid.Parse("e842529a-ac4a-48f4-9377-1786d94dd4e8");

        // Products for Category 1 (Fashion)
        public static readonly Guid FashionProduct1Guid = Guid.Parse("bc2983a5-b13c-49a4-9a6c-29c4dad9c355");
        public static readonly Guid FashionProduct2Guid = Guid.Parse("fedfd1c9-a73a-47bf-a635-370c193fc1df");
        public static readonly Guid FashionProduct3Guid = Guid.Parse("865770da-89af-4719-b00c-310b57d535e1");
        public static readonly Guid FashionProduct4Guid = Guid.Parse("bf49c60a-9173-4533-8ca6-182cc7f685eb");
        public static readonly Guid FashionProduct5Guid = Guid.Parse("271309f9-03ae-4a21-a98c-cb2b911d7996");

        // Products for Category 2 (Sport)
        public static readonly Guid SportProduct1Guid = Guid.Parse("46e235cb-57a7-4eaa-b8c0-fc8096daee7b");
        public static readonly Guid SportProduct2Guid = Guid.Parse("425f57d3-5bcd-42cd-a401-9a3a9af83c8f");
        public static readonly Guid SportProduct3Guid = Guid.Parse("30c4e1a7-3b0f-40e9-be69-903936c22290");
        public static readonly Guid SportProduct4Guid = Guid.Parse("7f49c05a-d60c-49e6-b804-f3eb5a65522f");
        public static readonly Guid SportProduct5Guid = Guid.Parse("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754");

        // Products for Category 3 (Home)
        public static readonly Guid HomeProduct1Guid = Guid.Parse("052e6003-3e9b-43f3-9d59-0656df90989e");
        public static readonly Guid HomeProduct2Guid = Guid.Parse("b4143d6b-c302-4215-82e9-c9123d2f2ee5");
        public static readonly Guid HomeProduct3Guid = Guid.Parse("41dde13b-dbcc-4f51-a31c-2231f94ddcab");
        public static readonly Guid HomeProduct4Guid = Guid.Parse("9101df8f-38e3-40de-a46a-8ca66c26222d");
        public static readonly Guid HomeProduct5Guid = Guid.Parse("8b441114-e030-4412-8952-2370a4b7f05a");

        // For Reviews
        public static readonly Guid Review1Guid = Guid.Parse("c9e3c10d-b843-434d-bcbe-bfe35e17dd52");
        public static readonly Guid Review2Guid = Guid.Parse("71dd6268-f87a-4816-a5bf-c94769a51473");
        public static readonly Guid Review3Guid = Guid.Parse("eb57b891-c019-46c9-9c6e-630a79d19787");
        public static readonly Guid Review4Guid = Guid.Parse("9aa483ac-872b-468c-af4f-2c1f94beec3a");
        public static readonly Guid Review5Guid = Guid.Parse("ca5b7d5d-309c-4973-ad8c-132a4142b5c1");
        public static readonly Guid Review6Guid = Guid.Parse("a4438f9a-a573-4967-96c3-6a38fcfb6132");
        public static readonly Guid Review7Guid = Guid.Parse("c2cd9d37-25d0-4b5d-a336-8214ce83b648");
        public static readonly Guid Review8Guid = Guid.Parse("dfc6ffd5-140c-4505-9428-7fe852a93afc");
        public static readonly Guid Review9Guid = Guid.Parse("38fb4093-965e-4e3f-a7a2-c19103fc239e");
        public static readonly Guid Review10Guid = Guid.Parse("30a4ff5e-3bd1-429d-9981-adbcd46e2537");

        // Addresses
        // Addresses for AdminUser
        public static readonly Guid AdminAddress1Guid = Guid.Parse("a1a1a1a1-1234-1234-1234-1234567890ab");
        public static readonly Guid AdminAddress2Guid = Guid.Parse("a2a2a2a2-1234-1234-1234-1234567890ab");
        public static readonly Guid AdminAddress3Guid = Guid.Parse("a3a3a3a3-1234-1234-1234-1234567890ab");

        // Addresses for User1
        public static readonly Guid User1Address1Guid = Guid.Parse("b1b1b1b1-1234-1234-1234-1234567890ab");
        public static readonly Guid User1Address2Guid = Guid.Parse("b2b2b2b2-1234-1234-1234-1234567890ab");
        public static readonly Guid User1Address3Guid = Guid.Parse("b3b3b3b3-1234-1234-1234-1234567890ab");

        // Addresses for User2
        public static readonly Guid User2Address1Guid = Guid.Parse("c1c1c1c1-1234-1234-1234-1234567890ab");
        public static readonly Guid User2Address2Guid = Guid.Parse("c2c2c2c2-1234-1234-1234-1234567890ab");
        public static readonly Guid User2Address3Guid = Guid.Parse("c3c3c3c3-1234-1234-1234-1234567890ab");


        public static List<User> Users()
        {
            return new List<User>
            {
                new() {
                    Id = AdminUserGuid,
                    FirstName = "Admin",
                    LastName = "admin",
                    Email = "admin@mail.com",
                    Avatar = "https://picsum.photos/1000/1000?random=150",
                    Password = _passwordHasher.HashPassword("admin") ,
                    Role = Role.Admin
                },
                new() {
                    Id = User1Guid,
                    FirstName = "John",
                    LastName = "Cena",
                    Email = "cena@mail.com",
                    Avatar = "https://picsum.photos/1000/1000?random=151",
                    Password = _passwordHasher.HashPassword("password"),
                    Role = Role.Customer
                },
                new() {
                    Id = User2Guid,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "doe@mail.com",
                    Avatar = "https://picsum.photos/1000/1000?random=152",
                    Password = _passwordHasher.HashPassword("password"),
                    Role = Role.Customer
                },
            };
        }

        public static List<Category> Categories()
        {
            return new List<Category>
            {
                new() {
                    Id = Category1Guid,
                    Name = "Fashion",
                    Image = "https://picsum.photos/1000/1000?random=99",
                },
                new() {
                    Id = Category2Guid,
                    Name = "Sport",
                    Image = "https://picsum.photos/1000/1000?random=100",
                },
                new() {
                    Id = Category3Guid,
                    Name = "Home",
                    Image = "https://picsum.photos/1000/1000?random=101",
                },

            };
        }

        public static List<Product> Products()
        {
            return new List<Product>
            {
                new() {
                    Id = FashionProduct1Guid,
                    Title = "Fashion Product 1",
                    Description = "Description for Fashion Product 1",
                    Price = 100,
                    CategoryId = Category1Guid,
                },
                new(){
                    Id = FashionProduct2Guid,
                    Title = "Fashion Product 2",
                    Description = "Description for Fashion Product 2",
                    Price = 140,
                    CategoryId = Category1Guid,
                },
                new() {
                    Id = FashionProduct3Guid,
                    Title = "Fashion Product 3",
                    Description = "Description for Fashion Product 3",
                    Price = 120,
                    CategoryId = Category1Guid,
                },
                new() {
                    Id = FashionProduct4Guid,
                    Title = "Fashion Product 4",
                    Description = "Description for Fashion Product 4",
                    Price = 200,
                    CategoryId = Category1Guid,
                },
                new() {
                    Id = FashionProduct5Guid,
                    Title = "Fashion Product 5",
                    Description = "Description for Fashion Product 5",
                    Price = 104,
                    CategoryId = Category1Guid,
                },

                // Products for Category 2 (Sport)
                new() {
                    Id = SportProduct1Guid,
                    Title = "Sport Product 1",
                    Description = "Description for Sport Product 1",
                    Price = 200,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct2Guid,
                    Title = "Sport Product 2",
                    Description = "Description for Sport Product 2",
                    Price = 240,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct3Guid,
                    Title = "Sport Product 3",
                    Description = "Description for Sport Product 3",
                    Price = 154,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct4Guid,
                    Title = "Sport Product 4",
                    Description = "Description for Sport Product 4",
                    Price = 333,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct5Guid,
                    Title = "Sport Product 5",
                    Description = "Description for Sport Product 5",
                    Price = 205,
                    CategoryId = Category2Guid,
                },

                // Products for Category 3 (Home)
                new() {
                    Id = HomeProduct1Guid,
                    Title = "Home Product 1",
                    Description = "Description for Home Product 1",
                    Price = 300,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct2Guid,
                    Title = "Home Product 2",
                    Description = "Description for Home Product 2",
                    Price = 32,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct3Guid,
                    Title = "Home Product 3",
                    Description = "Description for Home Product 3",
                    Price = 56,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct4Guid,
                    Title = "Home Product 4",
                    Description = "Description for Home Product 4",
                    Price = 143,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct5Guid,
                    Title = "Home Product 5",
                    Description = "Description for Home Product 5",
                    Price = 3000,
                    CategoryId = Category3Guid,
                }
            };
        }

        public static List<Image> Images()
        {
            return new List<Image>
            {
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Url = "https://picsum.photos/1000/1000?random=1" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Url = "https://picsum.photos/1000/1000?random=2" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Url = "https://picsum.photos/1000/1000?random=3" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Url = "https://picsum.photos/1000/1000?random=4" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Url = "https://picsum.photos/1000/1000?random=5" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Url = "https://picsum.photos/1000/1000?random=6" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Url = "https://picsum.photos/1000/1000?random=7" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Url = "https://picsum.photos/1000/1000?random=8" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Url = "https://picsum.photos/1000/1000?random=9" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Url = "https://picsum.photos/1000/1000?random=10" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Url = "https://picsum.photos/1000/1000?random=11" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Url = "https://picsum.photos/1000/1000?random=12" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Url = "https://picsum.photos/1000/1000?random=13" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Url = "https://picsum.photos/1000/1000?random=14" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Url = "https://picsum.photos/1000/1000?random=15" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Url = "https://picsum.photos/1000/1000?random=16" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Url = "https://picsum.photos/1000/1000?random=17" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Url = "https://picsum.photos/1000/1000?random=18" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Url = "https://picsum.photos/1000/1000?random=19" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Url = "https://picsum.photos/1000/1000?random=20" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Url = "https://picsum.photos/1000/1000?random=21" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Url = "https://picsum.photos/1000/1000?random=22" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Url = "https://picsum.photos/1000/1000?random=23" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Url = "https://picsum.photos/1000/1000?random=24" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Url = "https://picsum.photos/1000/1000?random=25" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Url = "https://picsum.photos/1000/1000?random=26" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Url = "https://picsum.photos/1000/1000?random=27" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Url = "https://picsum.photos/1000/1000?random=28" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Url = "https://picsum.photos/1000/1000?random=29" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Url = "https://picsum.photos/1000/1000?random=30" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Url = "https://picsum.photos/1000/1000?random=31" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Url = "https://picsum.photos/1000/1000?random=32" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Url = "https://picsum.photos/1000/1000?random=33" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Url = "https://picsum.photos/1000/1000?random=34" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Url = "https://picsum.photos/1000/1000?random=35" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Url = "https://picsum.photos/1000/1000?random=36" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Url = "https://picsum.photos/1000/1000?random=37" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Url = "https://picsum.photos/1000/1000?random=38" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Url = "https://picsum.photos/1000/1000?random=39" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Url = "https://picsum.photos/1000/1000?random=40" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Url = "https://picsum.photos/1000/1000?random=41" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Url = "https://picsum.photos/1000/1000?random=42" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Url = "https://picsum.photos/1000/1000?random=43" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Url = "https://picsum.photos/1000/1000?random=44" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Url = "https://picsum.photos/1000/1000?random=45" }
            };
        }

        public static List<Variant> Variants()
        {
            return new List<Variant>
            {
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Color = Color.Red, Size = Size.L, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },

                new() { Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Color = Color.Red, Size = Size.L, Quantity = 10 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Color = Color.Blue, Size = Size.XL, Quantity = 20 },
                new() { Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Color = Color.Black, Size = Size.XXXL, Quantity = 30 },
            };
        }
        public static List<Review> Reviews()
        {
            return new List<Review>
            {
                new() {
                    Id = Review1Guid,
                    Rating = 5,
                    Comment = "Great product!",
                    UserId = AdminUserGuid,
                    ProductId = FashionProduct1Guid
                },
                new() {
                    Id = Review2Guid,
                    Rating = 4,
                    Comment = "Really enjoyed this.",
                    UserId = User1Guid,
                    ProductId = SportProduct2Guid
                },
                new() {
                    Id = Review3Guid,
                    Rating = 3,
                    Comment = "Good quality, but expensive.",
                    UserId = AdminUserGuid,
                    ProductId = HomeProduct3Guid
                },
                new() {
                    Id = Review4Guid,
                    Rating = 4,
                    Comment = "Loved the design!",
                    UserId = User1Guid,
                    ProductId = FashionProduct4Guid
                },
                new() {
                    Id = Review5Guid,
                    Rating = 5,
                    Comment = "Perfect for my needs!",
                    UserId = User2Guid,
                    ProductId = SportProduct5Guid
                },
                new() {
                    Id = Review6Guid,
                    Rating = 4,
                    Comment = "Nice product, quick delivery.",
                    UserId = User2Guid,
                    ProductId = FashionProduct2Guid
                },
                new() {
                    Id = Review7Guid,
                    Rating = 5,
                    Comment = "Outstanding quality!",
                    UserId = User2Guid,
                    ProductId = HomeProduct1Guid
                },
                new() {
                    Id = Review8Guid,
                    Rating = 3,
                    Comment = "Decent, but expected more.",
                    UserId = AdminUserGuid,
                    ProductId = FashionProduct3Guid
                },
                new() {
                    Id = Review9Guid,
                    Rating = 5,
                    Comment = "Absolutely love this!",
                    UserId = User1Guid,
                    ProductId = HomeProduct5Guid
                },
                new() {
                    Id = Review10Guid,
                    Rating = 2,
                    Comment = "Not as described, disappointed.",
                    UserId = User2Guid,
                    ProductId = SportProduct3Guid
                }
            };
        }

        public static List<Address> Addresses()
        {
            return new List<Address>
            {
                // Addresses for AdminUser
                new() {
                    Id = AdminAddress1Guid,
                    Country = "Finland",
                    City = "Helsinki",
                    Street = "Street 1",
                    PostalCode = "00100",
                    UserId = AdminUserGuid
                },
                new() {
                    Id = AdminAddress2Guid,
                    Country = "Finland",
                    City = "Helsinki",
                    Street = "Street 2",
                    PostalCode = "00200",
                    UserId = AdminUserGuid
                },
                new() {
                    Id = AdminAddress3Guid,
                    Country = "Finland",
                    City = "Helsinki",
                    Street = "Street 3",
                    PostalCode = "00300",
                    UserId = AdminUserGuid
                },

                // Addresses for User1 (John Cena)
                new() {
                    Id = User1Address1Guid,
                    Country = "Finland",
                    City = "Espoo",
                    Street = "Street 1",
                    PostalCode = "02100",
                    UserId = User1Guid
                },
                new() {
                    Id = User1Address2Guid,
                    Country = "Finland",
                    City = "Espoo",
                    Street = "Street 2",
                    PostalCode = "02100",
                    UserId = User1Guid
                },
                new() {
                    Id = User1Address3Guid,
                    Country = "Finland",
                    City = "Espoo",
                    Street = "Street 3",
                    PostalCode = "02100",
                    UserId = User1Guid
                },

                // Addresses for User2 (John Doe)
                new() {
                    Id = User2Address1Guid,
                    Country = "Finland",
                    City = "Tampere",
                    Street = "Street 3",
                    PostalCode = "33100",
                    UserId = User2Guid
                },
                new() {
                    Id = User2Address2Guid,
                    Country = "Finland",
                    City = "Tampere",
                    Street = "Street 4",
                    PostalCode = "33100",
                    UserId = User2Guid
                },
                new() {
                    Id = User2Address3Guid,
                    Country = "Finland",
                    City = "Tampere",
                    Street = "Street 6",
                    PostalCode = "33100",
                    UserId = User2Guid
                },
            };
        }

    }
}