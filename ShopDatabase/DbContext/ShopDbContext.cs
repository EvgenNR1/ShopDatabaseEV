using ShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase.DbContext
{
    public class ShopDbContext : System.Data.Entity.DbContext
    {
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Food> Foods { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<ItemsInCart> ItemsInCart { get; set; }
    }
}
