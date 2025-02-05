namespace W4D3Assignment4._3 {
    internal class Customer {
        public int Id { get; }
        public string Name { get; }
        public int Unit { get; }
        public double Charges { get; private set; }
        public double SurchargeAmount { get; private set; }
        public double Total { get; private set; }

        public Customer(int id, string name, int unit) {
            this.Id = id;
            this.Name = name;
            this.Unit = unit;
            CalculateTotal();
        }

        private void CalculateTotal() {
            if (Unit <= 199)
                Charges = Unit * 1.20;
            else if (Unit >= 200 && Unit < 400)
                Charges = Unit * 1.50;
            else if (Unit >= 400 && Unit < 600)
                Charges = Unit * 1.80;
            else
                Charges = Unit * 2.00;

            if (Charges > 400)
                SurchargeAmount = Charges * 0.15;

            Total = Charges + SurchargeAmount;
        }

        internal void DisplayBill() {
            Console.WriteLine("\nElectricity Bill:");
            Console.WriteLine($"Customer IDNO : {Id}");
            Console.WriteLine($"Customer Name : {Name}");
            Console.WriteLine($"Unit Consumed : {Unit}");
            Console.WriteLine($"Amount Charges @ ${Charges / Unit:F2} per unit : {Charges:F2}");
            Console.WriteLine($"Surcharge Amount : {SurchargeAmount:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer : {Total:F2}");
        }
    }
}
