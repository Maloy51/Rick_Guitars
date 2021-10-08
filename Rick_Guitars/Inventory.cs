using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rick_Guitars
{
    class Inventory
    {
        private ArrayList guitars;

        public Inventory()
        {
            guitars = new ArrayList();
        }

        public void addGuitar(string serialNumber, double price, Builder builder,
            string model, Type type, Wood backWood, Wood topWood)
        {
            guitars.Add(new Guitar(serialNumber, price, builder, model, type,
                backWood, topWood));
        }

        public Guitar getGuitar(string serialNumber)
        {
            foreach(Guitar guitar in guitars)
            {
                if (serialNumber.Equals(guitar.getSerialNumber())) return (Guitar)guitar;
            }
            return null;
        }
        public ArrayList search(Guitar searchGuitar)
        {
            ArrayList matchingGuitars = new ArrayList();
            foreach(Guitar guitar in guitars)
            {
                // Серийный номер игнорируется, так как он уникален
                // Цена игнорируется, так как она уникальна
                if (guitar.getBuilder() != searchGuitar.getBuilder()) continue;
                string model = searchGuitar.getModel();
                if ((model != null) && (!model.Equals("") && (!model.Equals(guitar.getModel())))) continue;
                if (searchGuitar.getType() != guitar.getType()) continue;
                if (searchGuitar.getBackWood() != guitar.getBackWood()) continue;
                if (searchGuitar.getTopWood() != guitar.getTopWood()) continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
