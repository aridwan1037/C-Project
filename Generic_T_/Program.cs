//GENERIC <T>
//methode generic mampu menerima type data yang tanpa sepesifik disebutkan 
//ketika dipanggil sebagai contoh perintah printer.Print(200); 

//C# allows you to define generic classes, interfaces, abstract classes, fields, methods, 
//static methods, properties, events, delegates, and operators
//using the type parameter and without the specific data type. 

// Advantages of Generics
// Generics increase the reusability of the code. You don't need to write code to handle different data types.
// Generics are type-safe. You get compile-time errors if you try to use a different data type than the one specified in the definition.
// Generic has a performance advantage because it removes the possibilities of boxing and unboxing.


using System;
					
public class Program
{
	public static void Main()
	{
		Printer printer = new Printer();
        printer.Print("Contoh penggunaan Generic pada Method yang menerima type data int dan string !!!!");
		printer.Print<int>(100);
		printer.Print(200); // type infer from the specified value
		printer.Print<string>("Hello");
		printer.Print("World!\n"); // type infer from the specified value

        int[] intArray = {1, 2, 3};
        string[] stringArray = {"a", "b", "c"};
        Console.WriteLine("Contoh penggunaan Generic pada Method yang menerima type data array");
        printer.PrintElement(intArray);
        Console.WriteLine("");
        printer.PrintElement(stringArray);
        Console.WriteLine("\n");
//The actual data type of the item parameter will be specified at the time of instantiating the DataStore<T> class
        Console.WriteLine("Contoh Instance Generic");
        DataStore<string> cities = new DataStore<string>(); 
		cities.AddOrUpdate(0, "Mumbai");
		cities.AddOrUpdate(1, "Chicago");
		cities.AddOrUpdate(2, "London");

		Console.WriteLine(cities.GetData(2));

		DataStore<int> empIds = new DataStore<int>();
		empIds.AddOrUpdate(0, 50);
		empIds.AddOrUpdate(1, 65);
		empIds.AddOrUpdate(2, 89);
		
		Console.WriteLine(empIds.GetData(0));
	}
}

class Printer
{
    public void PrintElement <Tlist> (Tlist[] list){
        foreach (Tlist element in list)
        {
            Console.Write(element+" ");
        }
    }
    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}
class DataStore<T>
{
    private T[] _data = new T[10];
    
    public void AddOrUpdate(int index, T item)
    {
        if(index >= 0 && index < 10)
            _data[index] = item;
    }

	public T GetData(int index){
		if(index >= 0 && index < 10)
			return _data[index];
		else
			return default(T);
	}
}