using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system {
    public interface Shippable {
        void calculateShippingCost(float weight, float distance); // kargo ücreti hesapla
    }
}
