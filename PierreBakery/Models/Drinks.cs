namespace PierreBakery.Models {
    public class Drinks : Bakery {
        static public Dictionary<int, string> drinkTypes = new Dictionary<int, string> () { { 0, "Strawberry Smoothie" }, { 1, "Apple Juice" }, { 2, "Orange Juice" }, { 3, "Coffee" }, { 4, "Tea" }

        };
        public int getTotal () {
            int totalCost = 0;
            totalCost = (AmtDrinks * Price);
            return totalCost;
        }
        public int Price { get; set; }
        public int AmtDrinks { get; set; }
        public Drinks () {
            Price = 3;

        }
        public Drinks(int amtDrinks)
        {
            AmtDrinks=amtDrinks
        }
    }
}