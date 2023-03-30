using Namespace2;

namespace BasicDelegate
{
    // mendaftarkan method ke dalam delegate dengan cara ngapassing ke method lain

    internal static class Program
    {
        private static void Main()
        {
            subscriber subscriber = new();
            Publisher publisher = new();
            
            publisher.AddMethod(subscriber.Add);
            publisher.AddMethod(subscriber.Sub);
            publisher.AddMethod(subscriber.Square);
            publisher.Run(9);
            
            // publisher.AddMethod(subscriber.Printl);
            // publisher.run();
            // Console.WriteLine(publisher.run());

            
            // int[] data = { 2, 3, 4 };
            // MethodContainer.Transform(data, subscriber.Add);
            // foreach (int i in data)
            // {
            //     Console.WriteLine(i);
            // }
            // MethodContainer.Transform(data, subscriber.Sub);
            // foreach (int i in data)
            // {
            //     Console.WriteLine(i);
            // }
        }
    }
}

// int Sub(int b) => b - 1;
// int Mul(int c) => c * c;

// int[] values = { 1, 2, 3 };
// Transform (values, Square);
// foreach (int i in values)
// Console.Write (i + " ");
// void Transform (int[] values, Transformer t)
// {
// for (int i = 0; i < values.Length; i++)
// values[i] = t (values[i]);
// }

// int Square (int x) => x * x;
// int Cube (int x) => x * x * x;
// delegate int Transformer (int x);