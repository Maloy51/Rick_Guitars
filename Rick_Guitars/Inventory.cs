using System.Collections.Generic;

namespace Rick_Guitars
{
    class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(string serialNumber, double price, Builder builder,
            string model, Type type, int numStrings, Wood backWood, Wood topWood)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, numStrings, backWood, topWood);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            foreach(Guitar guitar in guitars)
            {
                if (serialNumber.Equals(guitar.getSerialNumber())) return guitar;
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach(Guitar guitar in guitars)
            {
                if (guitar.getSpec().matches(searchSpec)) matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
