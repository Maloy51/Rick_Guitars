using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rick_Guitars
{
    class Guitar
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;

        public Guitar(string serialNumber, double price, Builder builder, string model,
            NumStrings numStrings, Type type, Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = new GuitarSpec(builder, model, numStrings, type, backWood, topWood);
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public GuitarSpec getSpec()
        {
            return spec;
        }
    }
}
