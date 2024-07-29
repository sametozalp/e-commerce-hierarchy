using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system {
    public class Book : Product, Discountable{
        private string author {  get; set; }
        private string ISBN { get; set; } // uluslararası standart kitap numarası
        private int numberOfPages { get; set; }

        public void applyDiscount(int percentage) {
            throw new NotImplementedException();
        }

        public void getBookInfo() {
            displayDetails();
            Console.WriteLine("author: " + author);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("numberOfPages: " + numberOfPages);
        }
    }
}
