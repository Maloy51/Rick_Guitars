using System;
using System.Collections;

namespace Rick_Guitars
{
    class FindGuitarTester
    {
        static void Main(string[] args)
        {
            // Инициализация каталога игр:
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErlinLikes = new Guitar("", 0, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            ArrayList matchingGuitars = inventory.search(whatErlinLikes);
            if(matchingGuitars != null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Erin, you might like these guitars:");
                foreach(Guitar guitar in matchingGuitars)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  We have a " +
                        guitar.getBuilder() + " \"" + guitar.getModel() + "\" " +
                        guitar.getType() + " guitar:\n " +
                        guitar.getBackWood() + " back and sides,\n " +
                        guitar.getTopWood() + " top.\n You can have in for only $" +
                        guitar.getPrice() + "!\n-----------");
                }
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
                Console.ResetColor();
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("V9512", 1549.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("V95465", 7999.95, Builder.GIBSON, "1957 SJ-200 VINTAGE", Type.ACOUSTIC, Wood.SUNBURST, Wood.SUNBURST);
        }
    }
}
