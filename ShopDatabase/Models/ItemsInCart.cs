using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase.Models
{
    public class ItemsInCart
    {
        public Guid Id { get; set; }
        public Food Item { get; set; }

        public ShoppingCart Cart { get; set; }
        public double amount { get; set; }

        public ItemsInCart() { }
        public ItemsInCart(ShoppingCart cart, Food item, double amount)
        {
            Id = Guid.NewGuid();
            Cart = cart;
            Item = item;
            this.amount = amount;
        }
    }
}
