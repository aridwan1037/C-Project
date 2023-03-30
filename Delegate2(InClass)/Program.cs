// //Delegate

// using System;

// namespace FirstDelegate
// {
//     class Program
//     {
//         delegate T myDelegate<T>(T a, T b);
//         public static void Main(string[] args)
//         {
//             int a = 3;
//             int b = 4;
//             SubscriberClass<int> intSub = new();
//             SubscriberClass<double> doubleSub = new();
//             SubscriberClass<string> stringSub = new();


//             myDelegate<int> addDelegate = intSub.Add();
//             myDelegate<int> mulDelegate = intSub.Multiply();
            
//             Console.WriteLine(addDelegate(a, b));

//             Console.WriteLine(mulDelegate(a, b));
//         }
//     }
// class SubscriberClass<T>
//     {
//         public T Add(T a, T b)
//         {
//             if(a is int aa && b is int bb)
//             return (T)(object)(aa + bb);
//             else
//             return default;
//         }
//         public T Multiply(T c, T d)
//         {
//             if(c is int cc && d is int dd)
//             return (T)(object)(cc * dd);
//             else
//             return default;
//         }

//     }
// }

using System;

public delegate void MyDelegate(string msg);

public class Program
{
	public static void Main()
	{
		MyDelegate del = MethodA;
		del("Hello World");
			
		del = ClassB.MethodB;
		del("Hello World");
		
		del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
		del("Hello World");

	}
	public static void MethodA(string message)
	{
		Console.WriteLine("Called ClassA.MethodA() with parameter: "+ message);
	}
}

public class ClassA
{
	// public static void MethodA(string message)
	// {
	// 	Console.WriteLine("Called ClassA.MethodA() with parameter: "+ message);
	// }
}

public class ClassB
{
	public static void MethodB(string message)
	{
		Console.WriteLine("Called ClassB.MethodB() with parameter: "+ message);
	}
}