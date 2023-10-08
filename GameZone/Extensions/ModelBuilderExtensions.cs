using Microsoft.Extensions.DependencyInjection;

namespace GameZone.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedInitialData(this ModelBuilder modelBuilder)
        {
			#region Create Category
			modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {
                    new Category{Id= 1, Name="Sports"},
                    new Category{Id= 2, Name="Action"},
                    new Category{Id= 3, Name="Adventure"},
                    new Category{Id= 4, Name="Racing"},
                    new Category{Id= 5, Name="Fighting"},
                    new Category{Id= 6, Name="Film"},
                });
			#endregion

			#region Create Device
			modelBuilder.Entity<Device>()
                .HasData(new Device[]
                {
                    new Device{Id= 1,Name="PlayStation",Icon="bi bi-playstation"},
                    new Device{Id= 2,Name="XBox",Icon="bi bi-xbox"},
                    new Device{Id= 3,Name="Nintendo Switch",Icon="bi bi-nintendo-switch"},
                    new Device{Id= 4,Name="PC",Icon="bi bi-pc-display"},
                });
			#endregion

			#region Create Game
			modelBuilder.Entity<Game>()
                .HasData(new Game[]
                {
                    new Game{
                        Id = 1,
                        Name = "Assassin's Creed Valhalla",
                        Description = "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal and published by Ubisoft. It is the twelfth major installment in the Assassin's Creed series.",
                        CategoryId=2,
                        Cover = "b7743952-5bc5-48ed-b0fc-f7c643ef09ea.png",
                    },
                    new Game{
                        Id = 2,
                        Name = "Among Us",
                        Description = "Among Us is a multiplayer party game developed and published by InnerSloth.",
                        CategoryId=3,
                        Cover="5f2a1cff-7e87-424d-8198-9d2626e2b4de.png",
                    }
                    ,
                    new Game{
                        Id = 3,
                        Name = "FIFA 23",
                        Description = "FIFA 23 is a football simulation video game published by Electronic Arts.",
                        CategoryId=1,
                        Cover="61084baa-edf7-4b53-ab57-ab804f6fca23.png",
                    }
                    ,
                    new Game{
                        Id = 4,
                        Name = "The Witcher 3",
                        Description = "The Witcher 3: Wild Hunt is an action role-playing game developed and published by CD Projekt.",
                        CategoryId=2,
                        Cover="6146b83a-514f-4b68-8355-c2cfab7c5656.png",
                    }
                    ,
                    new Game{
                        Id = 5,
                        Name = "Red Dead Redemption 2",
                        Description = "Red Dead Redemption 2 is an action-adventure game developed and published by Rockstar Games.",
                        CategoryId=5,
                        Cover ="915e6c02-cec0-4692-aaca-13fedcb0247b.jpg",
                    }
                    ,
                    new Game{
                        Id = 6,
                        Name = "The Legend of Zelda",
                        Description = "The Legend of Zelda: Breath of the Wild is an action-adventure video game developed and published by Nintendo.",
                        CategoryId=5,
                        Cover = "814959b7-41d0-4412-ad0a-fe52f0fd3a91.jpg",
                    }
                    ,
                    new Game{
                        Id = 7,
                        Name = "Overwatch",
                        Description = "Overwatch is a team-based multiplayer first-person shooter game developed and published by Blizzard Entertainment.",
                        CategoryId=3,
                        Cover="597d0d8c-9ba6-441d-991a-c68b9df45023.jpg",
                    }
                    ,
                    new Game{
                        Id = 8,
                        Name = "Pokemon Go",
                        Description = "Pokémon GO is an augmented reality mobile game developed and published by Niantic in collaboration with Nintendo and The Pokémon Company.",
                        CategoryId=4,
                        Cover = "ae63a01a-564c-42f1-b0f0-8493171e4d6f.jpg",
                    }
                });
			#endregion

			#region Create GameDevice
			modelBuilder.Entity<GameDevice>()
                .HasData(new GameDevice[]
                {
                        new GameDevice{GameId = 1, DeviceId=1},
                        new GameDevice{GameId = 1, DeviceId=2},
                        new GameDevice{GameId = 2, DeviceId=1},
                        new GameDevice{GameId = 2, DeviceId=4},
                        new GameDevice{GameId = 3, DeviceId=1},
                        new GameDevice{GameId = 3, DeviceId=2},
                        new GameDevice{GameId = 3, DeviceId=3},
                        new GameDevice{GameId = 3, DeviceId=4},
                        new GameDevice{GameId = 4, DeviceId=1},
                        new GameDevice{GameId = 4, DeviceId=3},
                        new GameDevice{GameId = 5, DeviceId=1},
                        new GameDevice{GameId = 5, DeviceId=4},
                        new GameDevice{GameId = 6, DeviceId=1},
                        new GameDevice{GameId = 6, DeviceId=3},
                        new GameDevice{GameId = 7, DeviceId=1},
                        new GameDevice{GameId = 7, DeviceId=3},
                        new GameDevice{GameId = 7, DeviceId=4},
                        new GameDevice{GameId = 8, DeviceId=2},
                });
			#endregion

		}

		public static void SeedUserAndRoles(this ModelBuilder modelBuilder)
        {

            // Add Roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                 new IdentityRole { Name = FileSettings.AdminRole, NormalizedName = "ADMIN" },
                 new IdentityRole { Name = FileSettings.UserRole, NormalizedName = "USER" }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
            
            // Seed Users
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            List<ApplicationUser> users = new List<ApplicationUser>()
            {
                 new ApplicationUser {
                    FullName = "Mahmoud Alaa",
                    UserName = "mahmoud_alaa",
                    NormalizedUserName = "MAHMOUD_ALAA",
                    Email = "mahmoudalaa72@gmail.com",
                    NormalizedEmail = "MAHMOUDALAA72@GMAIL.COM",
                },

                new ApplicationUser {
                    FullName = "Ahmed Alaa",
                    UserName = "ahmed_alaa",
                    NormalizedUserName = "AHMED_ALAA",
                    Email = "ahmedalaa@gmail.com",
                    NormalizedEmail = "AHMEDALAA@GMAIL.COM",
                },
            };
            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            // Add Password For All Users
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Mahmoud_123");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Ahmed_123");

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId =
            roles.First(q => q.Name == FileSettings.AdminRole).Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId =
            roles.First(q => q.Name == FileSettings.UserRole).Id
            });


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
