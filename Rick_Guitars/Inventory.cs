﻿using System.Collections;

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
            string model, NumStrings numStrings, Type type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, numStrings, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            foreach(Guitar guitar in guitars)
            {
                if (serialNumber.Equals(guitar.getSerialNumber())) return (Guitar)guitar;
            }
            return null;
        }
        public ArrayList search(Guitar sGuitar)
        {
            GuitarSpec searchGuitar = sGuitar.getSpec();
            ArrayList matchingGuitars = new ArrayList();
            foreach(Guitar guitara in guitars)
            {
                GuitarSpec guitar = guitara.getSpec();
                // Серийный номер игнорируется, так как он уникален
                // Цена игнорируется, так как она уникальна
                if (guitar.getBuilder() != searchGuitar.getBuilder()) continue;
                string model = searchGuitar.getModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.getModel()))) continue;
                if (guitar.getNumString() != searchGuitar.getNumString()) continue;
                if (guitar.getType() != searchGuitar.getType()) continue;
                if (guitar.getBackWood() != searchGuitar.getBackWood()) continue;
                if (guitar.getTopWood() != searchGuitar.getBackWood()) continue;
                
                matchingGuitars.Add(guitara);
            }
            return matchingGuitars;
        }
    }
}
