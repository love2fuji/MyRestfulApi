using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyRestfulApi.Models
{
    public class MyRestfulApiContext : DbContext
    {
        public MyRestfulApiContext (DbContextOptions<MyRestfulApiContext> options)
            : base(options)
        {
        }

        public DbSet<MyRestfulApi.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<User>().HasData(
                new User {
                    UserID = 1,
                    UserName = "user1",
                    UserGruop = "admin"
                },
                new User
                {
                    UserID = 2,
                    UserName = "user2",
                    UserGruop = "admin"
                },
                new User
                {
                    UserID = 3,
                    UserName = "user3",
                    UserGruop = "user"
                }
                );
        }
    }
}
