using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system {
    public class Clothes : Product, Discountable {
        private char size;
        private string material { get; set; } // neyden yapılmış
        private string gender { get; set; }

        public void applyDiscount(int percentage) {
            throw new NotImplementedException();
        }

        // nasıl yıkanacak
        public void getCareInstructions() {
            Console.WriteLine("Deterjanlı suyla yıkamayın.");
        }
    }
}
