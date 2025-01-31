namespace W3D4Assignment3._4.models {
    internal abstract class Beverage {
        public string? Name { get; set; }
        public double Price { get; set; }
        public DrinkSize Size { get; set; }
        public bool IsHot { get; set; }
    }
}
