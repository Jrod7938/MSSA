namespace W10D2C1
{
    internal class Program
    {

        public delegate bool MyDelegate(int n);

        static void Main(string[] args)
        {

            bool result = CheckNum(40); // normal function
            MyDelegate myDel = new MyDelegate(CheckNum);

            var newResult = myDel(50);

            MyDelegate pointer = delegate (int num) {
                return (num > 500);
            };

            var result1 = pointer(50);

            MyDelegate pointer2 = (x) => x > 100;
            var result2 = pointer2(500);
        }

        static bool CheckNum(int num) { return num > 500; }
    }
}
