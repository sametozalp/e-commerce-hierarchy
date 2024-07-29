using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system {
    public abstract class Product {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private string category { get; set; }
        private int stockQuantity { get; set; }
        private float price { get; set; }

        // ürünün tüm özelliklerini göster
        public void displayDetails() {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("description: " + description);
            Console.WriteLine("category: " + category);
            Console.WriteLine("stockQuantity: " + stockQuantity);
            Console.WriteLine("price: " + price);
        }

        // % 20 indirim uygula
        public void applyDiscount(float price) {
            price = price - (price * 20 / 100);
        }
    }
}
