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
    }
}
