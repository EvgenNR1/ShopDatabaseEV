using ShopDatabase.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public double Sum
        {
            get
            {
                double ret = 0;
                foreach(var item in Items)
                {
                    ret += item.amount * item.Item.Price;
                }

                return ret;
            }
            set { }
        }
        public DateTime DateCreated { get; set; }
        public List<ItemsInCart> Items { get; set; }
        public Person Client { get; set; }
        public ShoppingCart() {
            Id = Guid.NewGuid();
            Sum = 0;
            Items = new List<ItemsInCart>();
            DateCreated = DateTime.Now;
            Client = new Person();
        }
        public ShoppingCart(Person client)
        {
            Id = Guid.NewGuid();
            Sum = 0;
            Items = new List<ItemsInCart>();
            DateCreated = DateTime.Now;
            Client = client;
        }
        public override string ToString()
        {
            return $"Date created shopping cart: {DateCreated}  SUM: {Sum}";
        }
        public void PrintItems(ShopDbContext db)
        {
            Console.WriteLine(this);
            if(db.ItemsInCart.Count() > 0)
            {
                foreach (var item in db.ItemsInCart)
                {
                    if (item.Cart != null)
                        if (Id == item.Cart.Id)
                            Console.WriteLine($"Name: {item.Item.Name}  Price: {item.Item.Price}  Amount: {item.amount}  SUM: {item.Item.Price * item.amount}");
                }
            }
                
                
        }
    }
}
