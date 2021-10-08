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
        private Builder builder;
        private string model;
        private Type type;
        private Wood backWood;
        private Wood topWood;

        public Guitar(string serialNumber, double price, Builder builder,
            string model, Type type, Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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
        public Builder getBuilder()
        {
            return builder;
        }
        public string getModel()
        {
            return model;
        }
        public Type getType()
        {
            return type;
        }
        public Wood getBackWood()
        {
            return backWood;
        }
        public Wood getTopWood()
        {
            return topWood;
        }
    }
}
