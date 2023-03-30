namespace Namespace2
{
    public class subscriber
    {
        public int Add(int a) => a + 1;
        public int Sub(int a) => a - 2;
        public int Square(int a) => a * a;
        public void Printl() => Console.WriteLine("mama"); //has wrong return type

    }
    class MethodContainer
    {
        // public static void Transform(int[] data, MyDelegate del)
        // {
        //     for (int i = 0; i < data.Length; i++)
        //         data[i] = del(data[i]);
        // }
    }
}