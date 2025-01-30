namespace W3D4Assignment3._4.models {
    internal class Coffee : Beverage {
        public RoastLevel RoastLevel { get; set; }
        public BeanType BeanType { get; set; }
        public Milk Milk { get; set; }
        public Sugar Sugar { get; set; }

        public static List<Coffee> CoffeeList = new List<Coffee>();

        public Coffee(string name, double price, DrinkSize size, bool isHot, RoastLevel roastLevel, BeanType beanType, Milk milk, Sugar sugar) {
            this.Name = name;
            this.Price = price;
            this.Size = size;
            this.IsHot = isHot;
            this.RoastLevel = roastLevel;
            this.BeanType = beanType;
            this.Milk = milk;
            this.Sugar = sugar;
        }

        public static void GenerateData() {
            CoffeeList.Add(new Coffee(CoffeeName.Espresso.ToString(), 2.99, DrinkSize.Small, true, RoastLevel.Dark, BeanType.Arabica, Milk.None, Sugar.None));
            CoffeeList.Add(new Coffee(CoffeeName.Latte.ToString(), 3.99, DrinkSize.Medium, true, RoastLevel.Medium, BeanType.Blend, Milk.Whole, Sugar.Medium));
            CoffeeList.Add(new Coffee(CoffeeName.Cappuccino.ToString(), 4.49, DrinkSize.Large, true, RoastLevel.Medium, BeanType.Robusta, Milk.Skim, Sugar.Low));
            CoffeeList.Add(new Coffee(CoffeeName.Americano.ToString(), 2.79, DrinkSize.Medium, true, RoastLevel.Light, BeanType.Arabica, Milk.None, Sugar.None));
            CoffeeList.Add(new Coffee(CoffeeName.Mocha.ToString(), 4.99, DrinkSize.Large, true, RoastLevel.Medium, BeanType.Blend, Milk.Oat, Sugar.High));
            CoffeeList.Add(new Coffee(CoffeeName.Macchiato.ToString(), 3.89, DrinkSize.Small, true, RoastLevel.Dark, BeanType.Robusta, Milk.Almond, Sugar.Low));
            CoffeeList.Add(new Coffee(CoffeeName.FlatWhite.ToString(), 4.29, DrinkSize.Medium, true, RoastLevel.Medium, BeanType.Arabica, Milk.Soy, Sugar.None));
        }
    }
}
