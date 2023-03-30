using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Functions functions = new();

        functions.Add(3, "foo");
        functions.Add(5, "bar");
        functions.Add(7, "baz");

        functions.Remove(7);

        Console.Write("Please Enter a Number of Limit : ");
        int lim = Convert.ToInt32(Console.ReadLine());
        functions.SetLimit(lim);

        functions.Execute();
        functions.Print();
    }
}
class Functions
{
    public int _limit;
    public SortedList<int, string> _listKey = new SortedList<int, string>();

    public ArrayList _Numbers = new ArrayList();
    public void Add(int num, string value)
    {
        _listKey.Add(num, value);
        Console.WriteLine("berhasil ditambahkan : " + num + " " + value);
    }
    public void Remove(int num)
    {
        _listKey.Remove(num);
        Console.WriteLine("berhasil dihapus key : " + num);
    }
    public void SetLimit(int limit)
    {
        _limit = limit;
    }
    public void Execute()
    {
        for (int i = 0; i <= _limit; i++)
        {
            _Numbers.Add(i);
        }

    }
    public void Print()
        {
            foreach (var item in _listKey)
            {
                Console.WriteLine($" Kode yang tersimpan adalah Key {item.Key}, dan value {item.Value}");
            }
            foreach (var item in _Numbers)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine("\n"+"fungsi sementara");
        }
}