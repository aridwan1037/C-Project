namespace Namespace2
{
    class Publisher
    {
        // public delegate void MyDelegate();
        public delegate int MyDelegate(int y);

        MyDelegate del;
        public void AddMethod(MyDelegate sub)
        {
            del = null;
            del += sub;
            Console.WriteLine("Method Added.. ");
            // Console.WriteLine($"Hasil dari {sub}, adalah {del(y)}");
        }
        public void Run(int y)
        {
            Console.WriteLine("Nilai baru adalah " + del(y));
        }
    }

}