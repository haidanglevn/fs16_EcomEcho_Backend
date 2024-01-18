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
                    Image = "https://images.unsplash.com/photo-1492707892479-7bc8d5a4ee93?q=80&w=1965&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                },
                new() {
                    Id = Category2Guid,
                    Name = "Sport",
                    Image = "https://picsum.photos/1000/1000?random=100",
                },
                new() {
                    Id = Category3Guid,
                    Name = "Home",
                    Image = "https://images.unsplash.com/photo-1514237487632-b60bc844a47d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                },

            };
        }

        public static List<Product> Products()
        {
            return new List<Product>
            {
                // Products for Category 1 (Fashion)
                new() {
                    Id = FashionProduct1Guid,
                    Title = "Elegant Summer Dress",
                    Description = "Light and breezy summer dress, perfect for warm days. Made from eco-friendly materials.",
                    Price = 99.99,
                    CategoryId = Category1Guid,
                },
                new(){
                    Id = FashionProduct2Guid,
                    Title = "Men's Casual Shirt",
                    Description = "Stylish and comfortable men's shirt, ideal for casual outings. Made with premium cotton.",
                    Price = 59.99,
                    CategoryId = Category1Guid,
                },
                new() {
                    Id = FashionProduct3Guid,
                    Title = "Designer Jeans",
                    Description = "High-quality denim jeans, offering both comfort and durability. A must-have in your wardrobe.",
                    Price = 89.99,
                    CategoryId = Category1Guid,
                },
                new() {
                    Id = FashionProduct4Guid,
                    Title = "Leather Jacket",
                    Description = "Classic leather jacket, perfect for a stylish look in cooler weather. Made from genuine leather.",
                    Price = 199.99,
                    CategoryId = Category1Guid,
                },
                new() {
                    Id = FashionProduct5Guid,
                    Title = "Trendy Sneakers",
                    Description = "Modern and comfortable sneakers, suitable for everyday wear. Combines style and practicality.",
                    Price = 74.99,
                    CategoryId = Category1Guid,
                },

                // Products for Category 2 (Sport)
                new() {
                    Id = SportProduct1Guid,
                    Title = "High-Performance Running Shoes",
                    Description = "Lightweight and durable running shoes, designed for optimal performance and comfort.",
                    Price = 119.99,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct2Guid,
                    Title = "Yoga Mat",
                    Description = "Eco-friendly yoga mat, providing excellent grip and comfort. Ideal for all levels of yoga practitioners.",
                    Price = 35.99,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct3Guid,
                    Title = "Fitness Tracker Watch",
                    Description = "Advanced fitness tracker with heart rate monitoring, GPS, and various sport modes.",
                    Price = 149.99,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct4Guid,
                    Title = "Gym Duffle Bag",
                    Description = "Spacious and durable gym bag with multiple compartments, perfect for carrying all your workout essentials.",
                    Price = 49.99,
                    CategoryId = Category2Guid,
                },
                new() {
                    Id = SportProduct5Guid,
                    Title = "Resistance Bands Set",
                    Description = "Versatile set of resistance bands, ideal for home workouts and strength training.",
                    Price = 29.99,
                    CategoryId = Category2Guid,
                },

                // Products for Category 3 (Home)
                new() {
                    Id = HomeProduct1Guid,
                    Title = "Luxury Bedding Set",
                    Description = "Premium quality bedding set, including a comforter, sheets, and pillowcases. Made with ultra-soft fabric.",
                    Price = 249.99,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct2Guid,
                    Title = "Aromatic Candle Set",
                    Description = "Set of fragrant candles, perfect for creating a relaxing and inviting atmosphere in your home.",
                    Price = 19.99,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct3Guid,
                    Title = "Decorative Throw Pillows",
                    Description = "Stylish throw pillows, adding a touch of elegance and comfort to any room.",
                    Price = 39.99,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct4Guid,
                    Title = "Wall Art Canvas",
                    Description = "Beautiful canvas print, ideal for enhancing the decor of your living space or office.",
                    Price = 89.99,
                    CategoryId = Category3Guid,
                },
                new() {
                    Id = HomeProduct5Guid,
                    Title = "Smart Home Assistant",
                    Description = "Voice-activated smart home assistant, capable of controlling various smart devices, providing information, and more.",
                    Price = 129.99,
                    CategoryId = Category3Guid,
                }
            };
        }

        public static List<Image> Images()
        {
            return new List<Image>
            {
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Url = "https://images.unsplash.com/photo-1675881149208-ac7db8cf2785?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fEVsZWdhbnQlMjBTdW1tZXIlMjBEcmVzc3xlbnwwfHwwfHx8MA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Url = "https://images.unsplash.com/photo-1675881149241-cd9a629fece5?q=80&w=1964&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct1Guid, Url = "https://images.unsplash.com/photo-1675881149207-4b021be0ecdd?q=80&w=1964&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Url = "https://images.unsplash.com/photo-1602810319250-a663f0af2f75?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Url = "https://images.unsplash.com/photo-1602810317536-5d5e8a552d15?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct2Guid, Url = "https://images.unsplash.com/photo-1603252109612-24fa03d145c8?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Url = "https://images.unsplash.com/photo-1694646023787-3a3b26fe2eb5?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Url = "https://images.unsplash.com/photo-1693439445707-258c80d7320e?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct3Guid, Url = "https://images.unsplash.com/photo-1679099253880-5b72997a2743?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Url = "https://images.unsplash.com/photo-1521223890158-f9f7c3d5d504?q=80&w=1492&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Url = "https://images.unsplash.com/photo-1520975661595-6453be3f7070?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct4Guid, Url = "https://images.unsplash.com/photo-1520975708797-fd2543e902bf?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Url = "https://images.unsplash.com/photo-1494609626232-e95194acf740?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Url = "https://images.unsplash.com/photo-1473010350295-2c82192ebd8e?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= FashionProduct5Guid, Url = "https://images.unsplash.com/photo-1474432420717-75023248d5b8?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Url = "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Url = "https://images.unsplash.com/photo-1511556670410-f6989d6b0766?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                // new() {Id=Guid.NewGuid(), ProductId= SportProduct1Guid, Url = "" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Url = "https://images.unsplash.com/photo-1591291621060-89264efbeaed?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Url = "https://images.unsplash.com/photo-1591291621164-2c6367723315?q=80&w=2071&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct2Guid, Url = "https://images.unsplash.com/photo-1549576490-b0b4831ef60a?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Url = "https://images.unsplash.com/photo-1557935728-e6d1eaabe558?q=80&w=2073&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Url = "https://images.unsplash.com/photo-1575311373937-040b8e1fd5b6?q=80&w=2088&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct3Guid, Url = "https://images.unsplash.com/photo-1600784694429-aafecca51fab?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Url = "https://images.unsplash.com/photo-1626368007885-99365a6011a3?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Url = "https://images.unsplash.com/photo-1631671608584-af001502e39d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                // new() {Id=Guid.NewGuid(), ProductId= SportProduct4Guid, Url = "" },

                new() {Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Url = "https://images.unsplash.com/photo-1518609571773-39b7d303a87b?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                // new() {Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Url = "" },
                // new() {Id=Guid.NewGuid(), ProductId= SportProduct5Guid, Url = "" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Url = "https://images.unsplash.com/photo-1682204803376-1c7dae90db28?q=80&w=2071&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                // new() {Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Url = "" },
                // new() {Id=Guid.NewGuid(), ProductId= HomeProduct1Guid, Url = "" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Url = "https://images.unsplash.com/photo-1602874801007-bd458bb1b8b6?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Url = "https://images.unsplash.com/photo-1570823635306-250abb06d4b3?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                // new() {Id=Guid.NewGuid(), ProductId= HomeProduct2Guid, Url = "" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Url = "https://images.unsplash.com/photo-1584100936595-c0654b55a2e2?q=80&w=1937&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Url = "https://images.unsplash.com/photo-1570786240066-c0d753711cfe?q=80&w=2081&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct3Guid, Url = "https://images.unsplash.com/photo-1629949009765-40fc74c9ec21?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Url = "https://images.unsplash.com/photo-1543487945-139a97f387d5?q=80&w=1960&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Url = "https://images.unsplash.com/photo-1538448746497-4b4feffb4afb?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct4Guid, Url = "https://images.unsplash.com/photo-1567225477277-c8162eb4991d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },

                new() {Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Url = "https://images.unsplash.com/photo-1528310385748-dba09bf1657a?q=80&w=2018&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Url = "https://images.unsplash.com/photo-1519558260268-cde7e03a0152?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new() {Id=Guid.NewGuid(), ProductId= HomeProduct5Guid, Url = "https://images.unsplash.com/photo-1578510879285-4aeb67eec1d2?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" }
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