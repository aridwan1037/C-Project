//Fungsi Static adalah dapat diakses langsung melalui class.method tanpa harus membuat instance baru
//LikeConsole merupakan Class yang memiliki 2 method yaitu WriteLine, dan PrintLine
//Method WriteLine merupakakan STATIC sehingga dapat diakses langsung melalui LikeConsole.WriteLine
//Method PrintLine BUKAN merupakakan static sehingga untuk mengakses harus membuat Instance terlebih dahulu 
//Melalui LikeConsole print = new LikeConsole();
//baru dapat memanggil method PrintLine --> print.PrintLine();

public static class Program
{
    private static void Main(string[] args) 
    {
        Console.WriteLine("Perbedaan dari Static Method dan Instance Method");
        LikeConsole.WriteLine(); //WriteLine merupakan method static dari class LikeConsole
        LikeConsole print = new LikeConsole();
        print.PrintLine(); //PrintLine BUKAN merupakan method static dari class LikeConsole
    }
}
class LikeConsole{
    public static void WriteLine()
    {
        Console.WriteLine("Ini adalah Contoh dari static Method");
    }
    public void PrintLine(){
        Console.WriteLine("Ini adalah Contoh dari instance Method");
    }
}