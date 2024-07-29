using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system {
    public class Electronic: Product, Shippable {
        private string brand {  get; set; }
        private int warrantyPeriod { get; set; } // garanti süresi (ay)
        private float powerConsumption { get; set; } // güç tüketimi

        // garanti bilgileri
        public void getWarrantyInfo() {
            Console.WriteLine("Garanti süresi " + warrantyPeriod + " aydır. Şartlarımız şunlardır.....");
        }

        // kullanım süresi boyunca ne kadar enerji tüketir
        public void calculatePowerUsage(int hours) {
            Console.WriteLine(hours * powerConsumption + " kadar enerji tüketir.");
        }

        public void calculateShippingCost(float weight, float distance) {
            Console.WriteLine(weight * distance / 1000 + " TL kargo ücreti vardır.");
        }
    }
}
