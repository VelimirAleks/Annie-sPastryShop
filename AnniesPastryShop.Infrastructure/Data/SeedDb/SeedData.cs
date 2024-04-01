using AnniesPastryShop.Infrastructure.Data.Models;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.AspNetCore.Identity;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb
{
    internal  class SeedData
    {
        public SeedData()
        {
            SeedAdministratorRole();
            SeedModeratorRole();
            SeedUsers();
            SeedCustomer();
            SeedAdministrator();
            SeedModerator();
            SeedCategories();
            SeedProducts();
            SeedPaymentMethods();
            SeedPictures();
            SeedReviews();
            SeedBlogs();
        }

        //Users
        public IdentityUser AdministratorUser { get; set; } = null!;
        public IdentityUser ModeratorUser { get; set; } = null!;
        public IdentityUser CustomerUser { get; set; } = null!;

        //Roles
        public IdentityRole AdministratorRole { get; set; } = null!;
        public IdentityRole ModeratorRole { get; set; } = null!;
        public Administrator Administrator { get; set; } = null!;
        public Moderator Moderator { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
     
        //Categories
        public Category Cakes { get; set; } = null!;
        public Category Pies { get; set; } = null!;
        public Category Cupcakes { get; set; } = null!; 
        
        //Products
        public Product ChocolateCake { get; set; } = null!;
        public Product RedVelvetCake { get; set; } = null!;
        public Product VanillaCake { get; set; } = null!;
        public Product LemonCake { get; set; } = null!;

        public Product ApplePie { get; set; } = null!;
        public Product CherryPie { get; set; } = null!;
        public Product BlueberryPie { get; set; } = null!;
        public Product PumpkinPie { get; set; } = null!;

        public Product MochaCupcake { get; set; } = null!;
        public Product StrawberryCupcake { get; set; } = null!;
        public Product BananaCupcake { get; set; } = null!;
        public Product PistachioCupcake { get; set; } = null!;

        //PaymentMethods
        public PaymentMethod Card { get; set; } = null!;
        public PaymentMethod PayPal { get; set; } = null!;
        public PaymentMethod BankTransfer { get; set; } = null!;
        public PaymentMethod CashOnDelivery { get; set; } = null!;

        //Pictures
        public List<Picture> ChocolateCakePictures { get; set; } = new List<Picture>();
        public List<Picture> RedVelvetCakePictures { get; set; } = new List<Picture>();
        public List<Picture> VanillaCakePictures { get; set; } = new List<Picture>();
        public List<Picture> LemonCakePictures { get; set; } = new List<Picture>();

        public List<Picture> ApplePiePictures { get; set; } = new List<Picture>();
        public List<Picture> CherryPiePictures { get; set; } = new List<Picture>();
        public List<Picture> BlueberryPiePictures { get; set; } = new List<Picture>();
        public List<Picture> PumpkinPiePictures { get; set; } = new List<Picture>();

        public List<Picture> MochaCupcakePictures { get; set; } = new List<Picture>();
        public List<Picture> StrawberryCupcakePictures { get; set; } = new List<Picture>();
        public List<Picture> BananaCupcakePictures { get; set; } = new List<Picture>();
        public List<Picture> PistachioCupcakePictures { get; set; } = new List<Picture>();

        //Reviews
        public List<Review> ChocolateCakeReviews { get; set; } = new List<Review>();
        public List<Review> CherryPieReviews { get; set; } = new List<Review>();
        public List<Review> MochaCupcakeReviews { get; set; } = new List<Review>();

        //Blog
        public Blog SweetDelights { get; set; } = null!;
        public Blog HolidaySpecials { get; set; } = null!;
        public Blog CakeDecoratingTips { get; set; } = null!;
        public Blog HealthyBites { get; set; } = null!;

        private void SeedAdministratorRole()
        {
            AdministratorRole = new IdentityRole(AdministratorRoleName);
        }

        private void SeedModeratorRole()  
        {
            ModeratorRole = new IdentityRole(ModeratorRoleName);
        }

        private void SeedUsers()
        { 
            var hasher = new PasswordHasher<IdentityUser>();

            CustomerUser = new IdentityUser
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com",
                Email = "customer@gmail.com",
                NormalizedEmail = "customer@gmail.com",
                PhoneNumber="0885629596"
            };
            CustomerUser.PasswordHash =
                hasher.HashPassword(CustomerUser, "customer1123");

            AdministratorUser = new IdentityUser
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com"
            };
            AdministratorUser.PasswordHash =
                hasher.HashPassword(AdministratorUser, "admin123");

            ModeratorUser = new IdentityUser
            {
                Id = "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                UserName = "moderator@gmail.com",
                NormalizedUserName = "moderator@gmail.com",
                Email = "moderator@gmail.com",
                NormalizedEmail = "moderator@gmail.com"
            };
            ModeratorUser.PasswordHash =
                hasher.HashPassword(ModeratorUser, "mode123");
        }

        private void SeedCustomer()
        {
            Customer = new Customer
            {
                Id = 1,
                UserId = CustomerUser.Id,
                FullName = "Velimir Aleksandrov",
                ImageUrl = "https://www.dropbox.com/scl/fi/2ubtzb4vzkyeolsbk55n8/315091820_218444830534539_6229220902423040954_n.jpg?rlkey=vakd1rubnbe5fa13m779jgr29&dl=1"
            };
        }

        private void SeedAdministrator()
        {
            Administrator = new Administrator
            {
                Id = 1,
                UserId = AdministratorUser.Id,
            };
        }

        private void SeedModerator()
        {
            Moderator = new Moderator
            {
                Id = 1,
                UserId = ModeratorUser.Id,
            };
        }
       
        private void SeedCategories()
        {
            Cakes = new Category
            {
                Id = 1,
                Name = "Cakes",
            };
            Pies = new Category
            {
                Id = 2,
                Name = "Pies",
            };
            Cupcakes = new Category
            {
                Id = 3,
                Name = "Cupcakes",
            };
        }

        private void SeedProducts()
        {
            ChocolateCake = new Product
            {
                Id = 1,
                Name = "Chocolate Cake",
                Price = 37.00m,
                Description = "Indulge in the richness of our chocolate cake, made with layers of moist chocolate and a decadent chocolate ganache frosting. It's the perfect treat for any chocolate lover!",
                ImageUrl = "https://www.dropbox.com/scl/fi/jfl56ni9f5de2s3sqmhw0/umesh-soni-LDnmyOaA-ew-unsplash.jpg?rlkey=pr92cxu0uh1y7z7ex7ioxwjzu&dl=1",
                CategoryId = 1,
            };
            RedVelvetCake = new Product
            {
                Id = 2,  
                Name = "Red Velvet Cake",
                Price = 40.00m,
                Description = "Experience the classic elegance of our Red Velvet Cake, featuring a velvety red crumb and luxurious cream cheese frosting. Each bite is a delightful blend of sweetness and sophistication.",
                ImageUrl = "https://www.dropbox.com/scl/fi/rfl598aqnm0iiixeyebyi/Red-velvet-taart-bakken-recept.jpg?rlkey=tal1b51u3afcitj3bhc5yq7o8&dl=1",
                CategoryId = 1,
            };
            VanillaCake = new Product
            {
                Id = 3,
                Name = "Vanilla Cake",
                Price = 35.00m,
                Description = "Delight your senses with our Vanilla Cake, boasting layers of fluffy vanilla sponge and creamy vanilla buttercream. It's a timeless classic that never fails to please!",
                ImageUrl = "https://www.dropbox.com/scl/fi/xhi1yt8q88xxld4es6ulk/Copycat-Whole-Foods-Berry-Chantilly-Cake.jpg?rlkey=6z1qeif038wynl8e5sg4krzf0&dl=1",
                CategoryId = 1,
            };
            LemonCake = new Product
            {
                Id = 4,
                Name = "Lemon Cake",
                Price = 38.00m,
                Description = "Enjoy the amazing taste of our lemon cake, made with layers of light lemon sponge cake and a rich lemon curd filling. It's a refreshing choice for those who crave a burst of citrus flavor!",
                ImageUrl = "https://www.dropbox.com/scl/fi/q21mza82deuh2ilvgy99n/Dairy-Free-Lemon-Cake-Caked-by-Katie.jpg?rlkey=p6w64sedulhmhqpnehdh1wt0q&dl=1",
                CategoryId = 1,
            };
            ApplePie = new Product
            {
                Id = 5,
                Name = "Apple Pie",
                Price = 25.00m,
                Description = "Enjoy the comforting taste of home with our Apple Pie, filled with tender slices of cinnamon-spiced apples and encased in a flaky, golden crust. It's a classic dessert that evokes memories of cozy gatherings and warm kitchen aromas.",
                ImageUrl = "https://www.dropbox.com/scl/fi/h1wughcwngoiu4j2pwfpv/Tourte-aux-pommes-Apple-Pie-Dessert-classique-Am-ricain.jpg?rlkey=107amabi0pirjykgmn668cul6&dl=1",
                CategoryId = 2,
            };
            CherryPie = new Product
            {
                Id = 6,
                Name = "Cherry Pie",
                Price = 28.00m,
                Description = "Treat yourself to the sweet allure of our Cherry Pie, brimming with plump, juicy cherries nestled within a buttery, flaky crust. Each bite is a symphony of tart and sweet flavors that captivates the palate.",
                ImageUrl = "https://www.dropbox.com/scl/fi/h7tsp3bllbxmed9gfgvau/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats-1.jpg?rlkey=4cwitp3zz8vvvvdiyyko9h400&dl=1",
                CategoryId = 2,
            };
            BlueberryPie = new Product
            {
                Id = 7,
                Name = "Blueberry Pie",
                Price = 26.00m,
                Description = "Indulge in the freshness of our Blueberry Pie, featuring a medley of plump, ripe blueberries encased in a golden-brown pastry crust. It's a delightful treat that bursts with vibrant flavor and wholesome goodness.",
                ImageUrl = "https://www.dropbox.com/scl/fi/m8zwvnvpyt7o3y4qx22ye/Simply-the-Best-Blueberry-Pie-Recipe-Sally-s-Baking-Addiction-1.jpg?rlkey=lmu3n9nsxtj66y82lba9qpoeo&dl=1",
                CategoryId = 2,
            };
            PumpkinPie = new Product
            {
                Id = 8,
                Name = "Pumpkin Pie",
                Price = 30.00m,
                Description = "Celebrate the flavors of the season with our Pumpkin Pie, made with smooth, creamy pumpkin filling infused with aromatic spices like cinnamon, nutmeg, and cloves. It's a quintessential dessert that brings warmth and comfort to any occasion.",
                ImageUrl = "https://www.dropbox.com/scl/fi/bza3ossr8ha2h223h566s/Sustainable-Eating.jpg?rlkey=8fgdqgaji17otjqvg53sqgdn6&dl=1",
                CategoryId = 2,
            };
            MochaCupcake = new Product
            {
                Id = 9,
                Name = "Mocha Cupcake",
                Price = 4.50m,
                Description = "Indulge in the perfect blend of coffee and chocolate with our Mocha Cupcake, featuring a moist chocolate base topped with rich espresso frosting. It's a decadent treat that delights the senses with every bite.",
                ImageUrl = "https://www.dropbox.com/scl/fi/6eqh8vkdin3x17hzh67vx/Caf-Mocha-Cupcakes-My-Baking-Addiction.jpg?rlkey=a7nym5zdy9koj6uyd6cbwqxw8&dl=1",
                CategoryId = 3,
            };
            StrawberryCupcake = new Product
            {
                Id = 10,
                Name = "Strawberry Cupcake",
                Price = 4.00m,
                Description = "Experience the freshness of summer with our Strawberry Cupcake, made with fluffy vanilla cake and topped with luscious strawberry frosting. It's a delightful confection that captures the essence of sun-ripened strawberries in every bite.",
                ImageUrl = "https://www.dropbox.com/scl/fi/dpjrnn75f8nb99gy40f3m/Homemade-Strawberry-Cupcakes.jpg?rlkey=bwph5bf0rxzsxc9dn5s16rgq0&dl=1",
                CategoryId = 3,
            };
            BananaCupcake = new Product
            {
                Id = 11,
                Name = "Banana Cupcake",
                Price = 4.00m,
                Description = "Indulge in the nostalgic flavor of our Banana Cupcake, made with ripe bananas and infused with warm spices like cinnamon and nutmeg. It's a comforting treat that brings back memories of homemade baked goods.",
                ImageUrl = "https://www.dropbox.com/scl/fi/v8f1b1dhgzcyafz992wxi/Banana-Cupcakes-with-Cream-Cheese-Frosting-1.jpg?rlkey=hn7vci8yio9zcoqdr2rjrjha1&dl=1",
                CategoryId = 3,
            };
            PistachioCupcake = new Product
            {
                Id = 12,
                Name = "Pistachio Cupcake",
                Price = 4.50m,
                Description = "Enjoy the delicate flavor of pistachio in our Pistachio Cupcake, featuring a light and fluffy almond sponge studded with chopped pistachios and topped with creamy pistachio frosting. It's a sophisticated treat that's perfect for any occasion.",
                ImageUrl = "https://www.dropbox.com/scl/fi/zop3gaf6hz6pwwp3mgho3/Pistachio-Green-Tea-Cupcakes-with-Matcha-Cream-Cheese-Frosting.jpg?rlkey=gs8rakwj4r28uu723tc9ny0kx&dl=1",
                CategoryId = 3,
            };
        }

        private void SeedPaymentMethods()
        {
            Card = new PaymentMethod
            {
                Id = 1,
                Name = "Card",
            };
            PayPal = new PaymentMethod
            {
                Id = 2,
                Name = "PayPal",
            };
            BankTransfer = new PaymentMethod
            {
                Id = 3,
                Name = "Bank Transfer",
            };
            CashOnDelivery = new PaymentMethod
            {
                Id = 4,
                Name = "Cash On Delivery",
            };
        }

        private void SeedPictures()
        {
            ChocolateCakePictures.AddRange(new List<Picture>
            { 
                new Picture
                {
                    Id = 1,
                    ImageUrl="https://www.dropbox.com/scl/fi/o2etu594dc2474nd5vl0f/Best-Chocolate-Cake-Recipe-My-Baking-Addiction.jpg?rlkey=0agguya24yh32jv5s4fboy8h3&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                new Picture
                {
                    Id = 2,
                    ImageUrl="https://www.dropbox.com/scl/fi/gayvfgchf5wxr1bpi9glh/Chocolate-Raspberry-Cheesecake-Baker-by-Nature.jpg?rlkey=1ajrtc4ytgdudc51bz249zlj0&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                new Picture
                {
                    Id = 3,
                    ImageUrl="https://www.dropbox.com/scl/fi/bcf92t6nldq2sl6h2lcjs/close-up-view-delicious-chocolate-cake-concept.jpg?rlkey=4y7xr1kdmz7ce6wctphr6x1we&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                new Picture
                {
                    Id = 4,
                    ImageUrl="https://www.dropbox.com/scl/fi/fxt280sfqfdg5qwaijk35/delicious-chocolate-cake-with-copy-space.jpg?rlkey=s44dk81z5h2i9rfczj8qsyf64&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                new Picture
                {
                    Id = 5,
                    ImageUrl="https://www.dropbox.com/scl/fi/qd8s8dmsguyxfnaqkmr7i/Moist-and-Fudgy-Chocolate-Cake-Butternut-Bakery.jpg?rlkey=u72ldtchsp5lj16i2q30oh7pg&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                 new Picture
                {
                    Id = 6,
                    ImageUrl="https://www.dropbox.com/scl/fi/x7oy572908eldnptwc0z5/Tarta-muerte-por-chocolate.jpg?rlkey=vtlg6qz752ynjq301wo3ji3wr&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                  new Picture
                {
                    Id = 7,
                    ImageUrl="https://www.dropbox.com/scl/fi/myhrmzpc7lwf2zt61t2pi/umesh-soni-Jl3O1S_Fk4-unsplash.jpg?rlkey=cgtawt4ohhgdjb7l1vkg6znuu&dl=1",
                    ProductId=ChocolateCake.Id,
                },
                   new Picture
                {
                    Id = 8,
                    ImageUrl="https://www.dropbox.com/scl/fi/xsnno4rcn1y0jb8dpycpy/umesh-soni-sSCldtAG7lk-unsplash.jpg?rlkey=74duhygeebl3gfocr0tftfejf&dl=1",
                    ProductId=ChocolateCake.Id,
                }
            });
            RedVelvetCakePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=9,
                    ImageUrl="https://www.dropbox.com/scl/fi/1pknj4bibwcsgok3lgpww/ai-generated-8569860_1280.jpg?rlkey=yhwdufs7fjxku6olb003q819j&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=10,
                    ImageUrl="https://www.dropbox.com/scl/fi/4fxkoygiyrtswn7xyrj21/amirali-mirhashemian-EfkMkUXs0fU-unsplash.jpg?rlkey=uutba03eoeb2l5mwgx9gz5d6o&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=11,
                    ImageUrl="https://www.dropbox.com/scl/fi/5ddz1v57wwz9sea58zy5q/cake-5377289_1280.jpg?rlkey=9yjbmr3s4vepwuk9q4glbykuw&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=12,
                    ImageUrl="https://www.dropbox.com/scl/fi/7r7varzvgbbwcnjjzjkow/Oreo-Red-Velvet-Cake-Salt-Baker.jpg?rlkey=lz5owdw9quux6lhivu6n9sb3l&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=13,
                    ImageUrl="https://www.dropbox.com/scl/fi/45cemyhbok2ndpxblif4a/Red-Velvet-Cake-with-Cream-Cheese-Frosting-Cooking-Classy.jpg?rlkey=rtrrwhno35uuxrttoqj3xoobl&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=14,
                    ImageUrl="https://www.dropbox.com/scl/fi/4hgnoov97niyx7k23ezyb/Red-Velvet-Cake-Recipe.jpg?rlkey=w3t7pfiy5lbl4uhch6huvymx6&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=15,
                    ImageUrl="https://www.dropbox.com/scl/fi/rfl598aqnm0iiixeyebyi/Red-velvet-taart-bakken-recept.jpg?rlkey=tal1b51u3afcitj3bhc5yq7o8&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=16,
                    ImageUrl="https://www.dropbox.com/scl/fi/8p9714npibflovprqf1l6/UVCcOKdg.jpg?rlkey=vl46na7sp5umys2dask4hzpgr&dl=1",
                    ProductId=RedVelvetCake.Id,
                },
                new Picture
                {
                    Id=17,
                    ImageUrl="https://www.dropbox.com/scl/fi/6qzous7x97fgb2dkp1rvi/front-view-red-cake-slice-fruit-cake-piece-inside-plate-with-fresh-cranberries-strawberries-grey-tea_140725-20808.jpg?rlkey=mqyi0eqa2ll5ratcbywutwp5z&dl=1",
                    ProductId=RedVelvetCake.Id,
                }
            });
            VanillaCakePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=18,
                    ImageUrl="https://www.dropbox.com/scl/fi/xpdb0spkxfx1okx6575tw/alex-lvrs-On2VseHUDXw-unsplash.jpg?rlkey=oe34rk54wzqoidnqxs1v12l1l&dl=1",
                    ProductId=VanillaCake.Id,
                },
                new Picture
                {
                    Id=19,
                    ImageUrl="https://www.dropbox.com/scl/fi/6ky3k5l7ser7yxe85fm6p/Basic-Vanilla-Cake.jpg?rlkey=dms3o5ulcoyf3h9mfhamqe7sg&dl=1",
                    ProductId=VanillaCake.Id,
                },
                new Picture
                {
                    Id=20,
                    ImageUrl="https://www.dropbox.com/scl/fi/mu9o3z3q74qa16mnbzs3t/Best-White-Cake-Recipe-Baker-by-Nature.jpg?rlkey=0lbnbclyezwrhys3pzs7h8ylq&dl=1",
                    ProductId=VanillaCake.Id,
                },
                new Picture
                {
                    Id=21,
                    ImageUrl="https://www.dropbox.com/scl/fi/ffwecsntxoxcycy304q0r/chiasheng-tai-B4QQAYBn8fU-unsplash.jpg?rlkey=rzf5i9oe7odelvdfgv2zbavsq&dl=1",
                    ProductId=VanillaCake.Id,
                },
                new Picture
                {
                    Id=22,
                    ImageUrl="https://www.dropbox.com/scl/fi/xhi1yt8q88xxld4es6ulk/Copycat-Whole-Foods-Berry-Chantilly-Cake.jpg?rlkey=6z1qeif038wynl8e5sg4krzf0&dl=1",
                    ProductId=VanillaCake.Id,
                },
                new Picture
                {
                    Id=23,
                    ImageUrl="https://www.dropbox.com/scl/fi/bxzrawil5mnd2732g6g0s/Strawberry-Shortcake-Cake.jpg?rlkey=z3ywp3uj6lpafn9mcnxicuw2o&dl=1",
                    ProductId=VanillaCake.Id,
                },
                new Picture
                {
                    Id=24,
                    ImageUrl="https://www.dropbox.com/scl/fi/kfozoc28tjfv2zjms6byv/The-Most-Amazing-Classic-Vanilla-Cake-Lil-Cookie.jpg?rlkey=u09qcejdcy4tkxenmpxj1i8ba&dl=1",
                    ProductId=VanillaCake.Id,
                }
            });
            LemonCakePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=25,
                    ImageUrl="https://www.dropbox.com/scl/fi/rtfduqrng1u9q1to5ziwv/cake-3060458_1280.jpg?rlkey=06lct5t2kg1f3pxuo3pn6cur9&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=26,
                    ImageUrl="https://www.dropbox.com/scl/fi/335e6zv45z5cyidi9v3f2/Creamsicle-Cake.jpg?rlkey=vlpig4o459e9cwxcs9x1y4oo5&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=27,
                    ImageUrl="https://www.dropbox.com/scl/fi/ka3zibige368w6shvxiy2/Lemon-Layer-Cake-with-The-Most-Lemony-Buttercream.jpg?rlkey=667gsce3yrgnsrszfxz590atc&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=28,
                    ImageUrl="https://www.dropbox.com/scl/fi/dh21m4u2jjiwt4o0dtlmh/Lemon-Sponge-Cake.jpg?rlkey=8rp241t0dz9l9dq5lq7mzvww3&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=29,
                    ImageUrl="https://www.dropbox.com/scl/fi/h2edxdrgb9dg6juz33xi8/Lemonade-Cake-with-Cream-Cheese-Frosting-Zesty-Lemon-Cake-Recipe.jpg?rlkey=jnhy2ohh41ui7w8g31vl3n6pk&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=30,
                    ImageUrl="https://www.dropbox.com/scl/fi/xq9qgn62rinqbnh6j93hv/pexels-pixabay-264939.jpg?rlkey=xzcxsvs1oo5g3znqh7xw5m5wm&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=31,
                    ImageUrl="https://www.dropbox.com/scl/fi/ssbzm1u8kcfc1pgc5hwfk/Thick-Homemade-Lemon-Curd.jpg?rlkey=j3guenwmvrhx811hxill7urtk&dl=1",
                    ProductId=LemonCake.Id,
                },
                new Picture
                {
                    Id=32,
                    ImageUrl="https://www.dropbox.com/scl/fi/s42uufah282b6h6zgbb4u/new-york-cheese-cake-7500156_1280.jpg?rlkey=c8ho65gvs22qa56hwt4g2s6p1&dl=1",
                    ProductId=LemonCake.Id,
                },
            });
            ApplePiePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=33,
                    ImageUrl="https://www.dropbox.com/scl/fi/b1x62yu33lrrv59tcp3hf/Apple-Pie-Recipe-The-BEST-Live-Well-Bake-Often.jpg?rlkey=2bt5ts08n7sms2wothwugnzw3&dl=1",
                    ProductId=ApplePie.Id,
                },
                new Picture
                {
                    Id=34,
                    ImageUrl="https://www.dropbox.com/scl/fi/198v4264d3rqqqdpnmrxj/Apple-Pie.jpg?rlkey=kdihdl3rcasom5fbk5da2mc34&dl=1",
                    ProductId=ApplePie.Id,
                },
                new Picture
                {   
                    Id=35,
                    ImageUrl="https://www.dropbox.com/scl/fi/4or8cx9jcwdfetdntfc3d/Deep-Dish-Apple-Pie-SundaySupper.jpg?rlkey=nx0s073wlmqf29mnacvld8a9g&dl=1",
                    ProductId=ApplePie.Id,
                },
                new Picture
                {
                    Id=36,
                    ImageUrl="https://www.dropbox.com/scl/fi/y1zilp730ev7s9yiftfqg/diliara-garifullina-D7X-GMeTV7U-unsplash.jpg?rlkey=cp4mpumb0uxq2orshwws9api0&dl=1",
                    ProductId=ApplePie.Id,
                },
                new Picture
                {
                    Id=37,
                    ImageUrl="https://www.dropbox.com/scl/fi/xqlw0a5a8iorexv0pzyk3/hugo-aitken-PqYvDBwpXpU-unsplash.jpg?rlkey=0b4gv7bcb8ghazye2s5r7diti&dl=1",
                    ProductId=ApplePie.Id,
                },
                new Picture
                {
                    Id=38,
                    ImageUrl="https://www.dropbox.com/scl/fi/m0it2y8xxvi8p3dibkanp/patrick-fore-LDnctIMQGeY-unsplash.jpg?rlkey=odgq0lzxy1tkm34q20rf6x2fc&dl=1",
                    ProductId=ApplePie.Id,
                }
            });
            CherryPiePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=39,
                    ImageUrl="https://www.dropbox.com/scl/fi/ij9a4nfuazqxk1tyvkjw0/Foolproof-Cherry-Pie-The-Best-Cherry-Pie-Recipe-from-Scratch.jpg?rlkey=fsf7j1aqezw7b84fzmdzjuzsm&dl=1",
                    ProductId=CherryPie.Id,
                },
                new Picture
                {
                    Id=40,
                    ImageUrl="https://www.dropbox.com/scl/fi/1u7730n7rxust5jehco4m/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats.jpg?rlkey=hvd3ztvgogqrr7hkug1p9m590&dl=1",
                    ProductId=CherryPie.Id,
                },
                new Picture
                {
                    Id=41,
                    ImageUrl="https://www.dropbox.com/scl/fi/h7tsp3bllbxmed9gfgvau/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats-1.jpg?rlkey=4cwitp3zz8vvvvdiyyko9h400&dl=1",
                    ProductId=CherryPie.Id,
                },
                new Picture
                {
                    Id=42,
                    ImageUrl="https://www.dropbox.com/scl/fi/5vqmj53sno2epmy3tndd6/Old-Fashioned-Cherry-Pie.jpg?rlkey=i4027pfxnk25rx72g5f6gmgrz&dl=1",
                    ProductId=CherryPie.Id,
                },
                new Picture
                {
                    Id=43,
                    ImageUrl="https://www.dropbox.com/scl/fi/mvuex013vlp0wv20ftbik/Simple-Vegan-Cherry-Pie-My-Vegan-Minimalist.jpg?rlkey=hbjkzkikpd08sszz9fzhqos5l&dl=1",
                    ProductId=CherryPie.Id,
                },
                new Picture
                {
                    Id=44,
                    ImageUrl="https://www.dropbox.com/scl/fi/nkdqj9jfos3926ij92rs0/Sour-Cherry-Pie.jpg?rlkey=cjap94gnsv5rrpnijx0vsult8&dl=1",
                    ProductId=CherryPie.Id,
                },
                new Picture
                {
                    Id=45,
                    ImageUrl="https://www.dropbox.com/scl/fi/9u2264pak6pjyx90uupo9/Simple-Vegan-Cherry-Pie-My-Vegan-Minimalist-1.jpg?rlkey=bv089cngrwm2bxodol8c0w6ya&dl=1",
                    ProductId=CherryPie.Id,
                }
            });
            BlueberryPiePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=46,
                    ImageUrl="https://www.dropbox.com/scl/fi/6i9hm4z5hs58o4c7dthin/Best-Blueberry-Pie-Recipe-vegan-easy.jpg?rlkey=6g1md46kl4hboldyyaxtpt435&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=47,
                    ImageUrl="https://www.dropbox.com/scl/fi/dcmw398ksz3st4b7gg1f3/Best-Ever-Blueberry-Pie.jpg?rlkey=umhreq1dv3sqsx2j82658zvc4&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=48,
                    ImageUrl="https://www.dropbox.com/scl/fi/t6mon1g94h5xt1nud7pgi/Blueberry-Cheesecake-Pie.jpg?rlkey=a1lxel1ckqkt2axli3xuqszdj&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=49,
                    ImageUrl="https://www.dropbox.com/scl/fi/khqktslyxp36pifhhqsw0/Blueberry-Pie-With-Coconut-Oil-Crust-Vegan.jpg?rlkey=aachu0o5nx37xcdb2tx4j81pq&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=50,
                    ImageUrl="https://www.dropbox.com/scl/fi/62l0fxd9a4m3vla6yli5d/Blueberry-Pie.jpg?rlkey=e7f7nzjxwg9est0rxfmqnqin1&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=51,
                    ImageUrl="https://www.dropbox.com/scl/fi/aozn1ya6kq238zqa079ft/Blueberry-Pie-1.jpg?rlkey=gvolf7axe2wpf23w3dk7tx402&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=52,
                    ImageUrl="https://www.dropbox.com/scl/fi/e4zv4py21c08znzige0sp/Classic-Blueberry-Pie-From-Scratch.jpg?rlkey=vqyxvrf0t13w6q3dojlocynth&dl=1",
                    ProductId=BlueberryPie.Id,
                },
                new Picture
                {
                    Id=53,
                    ImageUrl="https://www.dropbox.com/scl/fi/do4vzdr0eqbnpi4fztknm/Simply-the-Best-Blueberry-Pie-Recipe-Sally-s-Baking-Addiction.jpg?rlkey=lz51zzhc0c0dvgepvtbfe4fif&dl=1",
                    ProductId=BlueberryPie.Id,
                }
            });
            PumpkinPiePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=54,
                    ImageUrl="https://www.dropbox.com/scl/fi/89l6xvb147kovcbx8gdv7/Brown-Butter-Bourbon-Pecan-Pie.jpg?rlkey=igmhpie8jvd1oau8zvg35lwsd&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=55,
                    ImageUrl="https://www.dropbox.com/scl/fi/389notkf50zpviwd309cw/Easy-Thanksgiving-Pumpkin-Pie.jpg?rlkey=dtuvzrgd2n3nu7lwc5q2ikuuj&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=56,
                    ImageUrl="https://www.dropbox.com/scl/fi/nj7prp3lxzcs33wnrzepy/Gluten-Free-Dairy-Free-Pumpkin-Pie.jpg?rlkey=2ely5y2ebspoie200q3ymkujq&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=57,
                    ImageUrl="https://www.dropbox.com/scl/fi/j4onkyzzs2h3zkczj3xqy/NameBright-Coming-Soon.jpg?rlkey=jxosgoqgxrv1q63bh1hew2b8l&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=58,
                    ImageUrl="https://www.dropbox.com/scl/fi/poqazei76a2vcagnv1ejd/Perfect-Pumpkin-Pie-Cooking-Classy.jpg?rlkey=x2473hkwpykqzubxyheyht1fp&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=59,
                    ImageUrl="https://www.dropbox.com/scl/fi/9g5c8o3a1h4o725is7iy9/Pumpkin-Pie-Recipe-VIDEO.jpg?rlkey=nvqxp3pabkms71g0evmcwfxxj&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=60,
                    ImageUrl="https://www.dropbox.com/scl/fi/unq720ne5hkzjj43or1vy/Pumpkin-Pie-Recipe.jpg?rlkey=l57p8vuk86f88449d0lmxcgrd&dl=1",
                    ProductId=PumpkinPie.Id,
                },
                new Picture
                {
                    Id=61,
                    ImageUrl="https://www.dropbox.com/scl/fi/a2y5dlvgygvlvysl1binn/The-Best-Pumpkin-Pie-Recipe-STACIE-FLINNER.jpg?rlkey=8oh1b8savk8qhtrnixifdpob7&dl=1",
                    ProductId=PumpkinPie.Id,
                }
            });
            MochaCupcakePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=62,
                    ImageUrl="https://www.dropbox.com/scl/fi/jejaub0d6l4rasqxpzhz2/Caf-Mocha-Cupcakes.jpg?rlkey=inbu6swikodonp9fawuyjqbua&dl=1",
                    ProductId=MochaCupcake.Id,
                },
                new Picture
                {
                    Id=63,
                    ImageUrl="https://www.dropbox.com/scl/fi/6dxgfsj7890tp52rsjsne/Chocolate-Mocha-Cupcake.jpg?rlkey=hlbxsdfvea5ua44r7bjuabfgy&dl=1",
                    ProductId=MochaCupcake.Id,
                },
                new Picture
                {
                    Id=64,
                    ImageUrl="https://www.dropbox.com/scl/fi/v51328mpw3e490mf593dy/Mocha-Cupcakes-Plus-Coffee-Bark-Recipe.jpg?rlkey=y1el9g2bs6a85uasefykihewe&dl=1",
                    ProductId=MochaCupcake.Id,
                },
                new Picture
                {
                    Id=65,
                    ImageUrl="https://www.dropbox.com/scl/fi/chfqjvzkwfw988ouckzsl/Mocha-Cupcakes-with-Espresso-Buttercream-Recipe-by-Alpine-Ella.jpg?rlkey=2z5raaokb7so0114y40xk5cep&dl=1",
                    ProductId=MochaCupcake.Id,
                },
                new Picture
                {
                    Id=66,
                    ImageUrl="https://www.dropbox.com/scl/fi/flsja5cbnhrxccrlpzyj9/Mocha-Cupcakes-1.jpg?rlkey=9vdcywr46s6pksxevmxndqelx&dl=1",
                    ProductId=MochaCupcake.Id,
                },
                new Picture
                {
                    Id=67,
                    ImageUrl="https://www.dropbox.com/scl/fi/0cnyn6o4ulj5y6mr2toia/Mocha-Cupcakes-2.jpg?rlkey=qcu4hw039p7g2g8nrjg5cyqlq&dl=1",
                    ProductId=MochaCupcake.Id,
                },
            });
            StrawberryCupcakePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=68,
                    ImageUrl="https://www.dropbox.com/scl/fi/bogvoufvdvmjvjqa3dedi/Die-Vanille-Cupcakes-Ihr-bester-Party-Freund.jpg?rlkey=t8s80zh9jdvsf2bpqr900yaw7&dl=1",
                    ProductId=StrawberryCupcake.Id,
                },
                new Picture
                {
                    Id=69,
                    ImageUrl="https://www.dropbox.com/scl/fi/gl3se9u7vn9wtrl4efnpy/Fresh-Strawberry-Cupcakes-Cupcake-Recipe-Loaded-With-Strawberries.jpg?rlkey=zywlvvv6sz6ivexkdob8s5kt4&dl=1",
                    ProductId=StrawberryCupcake.Id,
                },
                new Picture
                {
                    Id=70,
                    ImageUrl="https://www.dropbox.com/scl/fi/hagwv1zx1wpzs2jj6s612/Strawberry-Cupcakes-In-Bloom-Bakery.jpg?rlkey=74iyv19rphfmz72qemcnubcws&dl=1",
                    ProductId=StrawberryCupcake.Id,
                },
                new Picture
                {
                    Id=71,
                    ImageUrl="https://www.dropbox.com/scl/fi/yefkc8iym37v1ulj6iv0c/Strawberry-Cupcakes-Strawberry-Frosting-Live-Well-Bake-Often.jpg?rlkey=6hmavgwy4ztdag5vxmrv5jdvl&dl=1",
                    ProductId=StrawberryCupcake.Id,
                },
                  new Picture
                {
                    Id=72,
                    ImageUrl="https://www.dropbox.com/scl/fi/hcegkksrkkwqdioer0dvu/Strawberry-Shortcake-Cupcakes.jpg?rlkey=5b9cpfxmgoopq3uu93i33tsod&dl=1",
                    ProductId=StrawberryCupcake.Id,
                },
                new Picture
                {
                    Id=73,
                    ImageUrl="https://www.dropbox.com/scl/fi/9fr4vfibkjfg3kd7xeiab/The-BEST-Homemade-Strawberry-Frosting-How-to-Make-Frosting.jpg?rlkey=bf76sh659ztvd9k0ja9e3skgi&dl=1",
                    ProductId=StrawberryCupcake.Id,
                }
            });
            BananaCupcakePictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Id=74,
                    ImageUrl="https://www.dropbox.com/scl/fi/f6u1lgfg24lkpnrxbvx5o/Banana-Caramel-Cupcakes-with-Caramel-Cream-Cheese-Frosting-Recipe.jpg?rlkey=rpxy5aotrpcgomkk3ysgjlgsi&dl=1",
                    ProductId=BananaCupcake.Id,
                },
                 new Picture
                {
                    Id=75,
                    ImageUrl="https://www.dropbox.com/scl/fi/053x0ximzu2wasdehukwj/Banana-Chocolate-Chip-Cupcakes-with-Cream-Cheese-Frosting-Cooking-Classy.jpg?rlkey=6i8d1ie5day2j5jo06m8ecfl4&dl=1",
                    ProductId=BananaCupcake.Id,
                },
                  new Picture
                {
                    Id=76,
                    ImageUrl="https://www.dropbox.com/scl/fi/8cw9phg2slso2c7ftbo3e/Banana-Cupcakes-Recipe-Sally-s-Baking-Addiction.jpg?rlkey=1dz9e1668tlf74pg74fnvzexl&dl=1",
                    ProductId=BananaCupcake.Id,
                },
                   new Picture
                {
                    Id=77,
                    ImageUrl="https://www.dropbox.com/scl/fi/9mysqrd34tyj67ito28bf/Banana-Cupcakes-with-Cream-Cheese-Frosting.jpg?rlkey=wghu1ojk398veztcb1u71xots&dl=1",
                    ProductId=BananaCupcake.Id,
                },
                   new Picture
                {
                    Id=78,
                    ImageUrl="https://www.dropbox.com/scl/fi/b4w74ejtsu4uorgukbcaz/Peanut-Butter-Banana-Cupcakes-The-Best-Cupcake-Recipe.jpg?rlkey=j3gjapl4dryk52da27stwcf75&dl=1",
                    ProductId=BananaCupcake.Id,
                },
                    new Picture
                {
                    Id=79,
                    ImageUrl="https://www.dropbox.com/scl/fi/v8f1b1dhgzcyafz992wxi/Banana-Cupcakes-with-Cream-Cheese-Frosting-1.jpg?rlkey=hn7vci8yio9zcoqdr2rjrjha1&dl=1",
                    ProductId=BananaCupcake.Id,
                }
            });
            PistachioCupcakePictures.AddRange(new List<Picture>
           {
                new Picture
                {
                    Id=80,
                    ImageUrl="https://www.dropbox.com/scl/fi/c0id55usyvdtpvlm63zcu/Cannoli-Cupcakes.jpg?rlkey=w2ygc4vbl2mw83hdh198bhsw4&dl=1",
                    ProductId=PistachioCupcake.Id,
                },
                new Picture
                {
                    Id=81,
                    ImageUrl="https://www.dropbox.com/scl/fi/p27ytufvbm9kug9qajsmf/Chocolate-Cupcakes-with-Pistachios-and-Cognac-Buttercream-Frosting.jpg?rlkey=trwjtuu1ceapsexycd2x42kgf&dl=1",
                    ProductId=PistachioCupcake.Id,
                },
                new Picture
                {
                    Id=82,
                    ImageUrl="https://www.dropbox.com/scl/fi/mamd7esz4lxuy9b0jakef/Chocolate-Pistachio-Cupcakes.jpg?rlkey=q61pcchjfrcgv4fezbnvb04xg&dl=1",
                    ProductId=PistachioCupcake.Id,
                },
                new Picture
                {
                    Id=83,
                    ImageUrl="https://www.dropbox.com/scl/fi/jx92qgiganev8uyntueh8/Matcha-Green-Tea-Cupcakes.jpg?rlkey=8d4wwzk0dkpz0dsdoepnzahh8&dl=1",
                    ProductId=PistachioCupcake.Id,
                },
                new Picture
                {
                    Id=84,
                    ImageUrl="https://www.dropbox.com/scl/fi/n1ffp5xztnmggofptrd1k/Pistachio-Cupcakes-Recipe.jpg?rlkey=8xdf9rb9quxepq6sd7jb2w32x&dl=1",
                    ProductId=PistachioCupcake.Id,
                },
                new Picture
                {
                    Id=85,
                    ImageUrl="https://www.dropbox.com/scl/fi/3nlucly1o1epiequ8kw3q/Pistachio-Cupcakes-with-Orange-Mascarpone-Frosting.jpg?rlkey=3ph9ht9woaohnkzbrqkos8igv&dl=1",
                    ProductId=PistachioCupcake.Id,
                },
                new Picture
                {
                    Id=86,
                    ImageUrl="https://www.dropbox.com/scl/fi/z3mhkmgqvsc291wzy6pgv/Pistachio-Rosewater-Cupcakes-with-Saffron-Frosting.jpg?rlkey=dpeglysqx3dnqck5p6d5mpofn&dl=1",
                    ProductId=PistachioCupcake.Id,
                }
           });
        }
        private void SeedReviews()
        {
            ChocolateCakeReviews.Add(new Review
            {
                Id=1,
                Rating=5,
                Comment= "Absolutely delicious! The chocolate flavor was rich and the frosting was divine.",
                CreatedOn = new DateTime(2023, 3, 10),
                ProductId = ChocolateCake.Id,
                CustomerId = Customer.Id,
            });
            CherryPieReviews.Add(new Review
            {
                Id = 2,
                Rating = 4,
                Comment = "Great pie, but could be a bit less sweet for my taste",
                CreatedOn = new DateTime(2024, 1, 15),
                ProductId=CherryPie.Id,
                CustomerId=Customer.Id,
            });
            MochaCupcakeReviews.Add(new Review
            {
                Id = 3,
                Rating = 5,
                Comment = "Amazing cupcakes! The coffee flavor was perfect and the frosting was so creamy.",
                CreatedOn = new DateTime(2024, 4, 20),
                ProductId = MochaCupcake.Id,
                CustomerId = Customer.Id,
            });
        }

        private void SeedBlogs()
        {
            SweetDelights = new Blog
            {
                Id = 1,
                Title = "Sweet Delights: Introducing Our Newest Pastry Creations!",
                Content = "Step into a world of unparalleled sweetness and indulge your senses with our latest pastry creations! At Annie's Pastry Shop, we're thrilled to unveil our newest additions to the menu, meticulously crafted by our expert pastry chefs. From luscious cakes adorned with intricate designs to delicate pastries bursting with flavor, each creation is a masterpiece waiting to be savored. Join us on a journey of taste and discover the irresistible treats that await you at Annie's Pastry Shop.",
                ImageUrl = "https://www.dropbox.com/scl/fi/dwi4j1ek5sey5sdt2zieu/FOTOBODEN-INDIVIDUELL-BEDRUCKBARER-VINYLBODEN.jpg?rlkey=flbp0ko4cym1v9fhg9sf0x9nc&dl=1",
                CreatedAt =new DateTime(2023,10,11)
            };
            HolidaySpecials = new Blog
            {
                Id = 2,
                Title = "Holiday Specials: Festive Treats to Celebrate the Season",
                Content = "Tis the season to spread joy and indulge in the magic of the holidays with our delightful selection of festive treats! Here at Annie's Pastry Shop, we're pulling out all the stops to ensure your celebrations are filled with sweetness and cheer. From traditional gingerbread cookies infused with warm spices to whimsical peppermint cupcakes topped with fluffy frosting, our holiday specials are guaranteed to delight your taste buds and evoke the spirit of the season. Don't miss out on the opportunity to add a touch of magic to your holiday gatherings with our limited-time offerings!",
                ImageUrl = "https://www.dropbox.com/scl/fi/lxo1tjn4re7ht3anh58d7/If-you-are-anywhere-in-the-city-center-of-Le-Mans.jpg?rlkey=yp6wjxl8lbb2h3zoolgsrb90h&dl=1",
                CreatedAt = new DateTime(2023, 12, 24)
            };
            CakeDecoratingTips = new Blog
            {
                Id = 3,
                Title = "The Art of Cake Decorating: Tips and Tricks from Our Experts",
                Content = "Calling all aspiring bakers and cake enthusiasts! Prepare to embark on an exciting journey into the world of cake decorating with insights and guidance from our seasoned experts. At Annie's Pastry Shop, we believe that every cake tells a story, and we're here to help you bring your creative visions to life. In this exclusive feature, we'll share insider tips, innovative techniques, and expert advice to elevate your cake decorating skills to new heights. Whether you're a novice looking to learn the basics or a seasoned pro seeking inspiration, our comprehensive guide is your gateway to mastering the art of cake decoration.",
                ImageUrl = "https://www.dropbox.com/scl/fi/9b5jca6a1blm0c62k29r4/Blood-Splattered-Cake.jpg?rlkey=k3obmzm1hin7t28775dz5lbgv&dl=1",
                CreatedAt = new DateTime(2024, 02, 07)
            };
            HealthyBites = new Blog
            {
                Id = 4,
                Title = "Healthy Bites: Exploring Gluten-Free and Vegan Options",
                Content = "Attention, health-conscious dessert enthusiasts! Get ready to embark on a delectable journey of discovery as we unveil our latest offerings: a tantalizing array of gluten-free and vegan pastry options that cater to your dietary preferences without compromising on taste or quality. At Annie's Pastry Shop, we believe that everyone deserves to indulge in the joy of sweet treats, regardless of dietary restrictions. That's why our dedicated team of pastry chefs has worked tirelessly to create a selection of wholesome delights that are free from gluten, dairy, and animal products. From moist and fluffy cupcakes to decadent cookies and everything in between, our gluten-free and vegan options are sure to satisfy your cravings and leave you craving more.",
                ImageUrl = "https://www.dropbox.com/scl/fi/d9g8ibm0235gdf8z2ndw9/Chocolate-Strawberry-Cake.jpg?rlkey=mdx8hl5kt7exhol04bz686kfo&dl=1",
                CreatedAt = new DateTime(2024, 03, 15)
            };
        }

    }
}
