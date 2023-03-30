class Program
{
    public static void Main()
    {
        Calculator<int> calInt = new();
        Calculator<string> calString = new();
        Calculator<double> calDouble = new();

        //INT, add + multiply
        calDelegate<int> addDelegate = calInt.add;
        calDelegate<int> mulDelegate = calInt.multiply;

        //String, add
        calDelegate<string> addDelString = calString.add;

        //try double
        calDelegate<double> addDouble = calDouble.add;
        //calDelegate allDelegate = mulDelagate + addDelegate;

        Console.WriteLine("Add int : " + addDelegate(10, 5));
        Console.WriteLine("mul int : " + mulDelegate(10, 5));

        Console.WriteLine("Add string : " + addDelString("Hello ", "wolrd."));

        Console.WriteLine("Add : " + addDouble(10.42, 3.4));
        // Console.WriteLine("Mul : " + mulDelagate(10, 5));
        // Console.WriteLine("All : " + allDelegate(10, 5));

    }

    public delegate T calDelegate<T>(T a, T b);

    class Calculator<K>
    {
        public K add(K a, K b)
        {
            if (a is int aa && b is int bb)
            {
                return (K)(object)(aa + bb);
            }
            else if (a is string aaa && b is string bbb)
            {
                return (K)(object)(aaa + bbb);
            }
            else
            {
                return default;
            }
        }

        public K multiply(K a, K b)
        {
            if (a is int aa && b is int bb)
            {
                return (K)(object)(aa * bb);
            }
            return default;
        }
    }
}