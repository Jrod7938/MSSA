namespace W4D2C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversions.CelciusToFahrenheit(-32));
            int n1 = 34;
            int n2 = 56;
            Swap<int>.SwapData(ref n1, ref n2);
            Console.WriteLine($"N1: {n1}\nN2: {n2}");
        }
    }
}
