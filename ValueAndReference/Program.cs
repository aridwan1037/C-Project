//VALUE TYPE
//nilai dari antar variable TIDAK akan terikat ketika a=b di declare
//nilai dari variable TIDAK akan berubah walaupun sudah menggunakan method (void, int)
//yang disimpan hanya nilainya saja dari suatu variable
// disimpan di stack
// diakses lebih cepat dan ringan

//REFERENCE TYPE
//nilai antar variable akan terikat ketika c=d di declare
//nilai dari variable akan berubah walaupun sudah menggunakan method
//yang disimpan adalah alamat dari variable
//disimpan di heap

internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pertanyaanya adalah");
        Console.WriteLine("a = 5");
        Console.WriteLine("b = a");
        Console.WriteLine("b = 8");
        Console.WriteLine("BERAPA NILAI a dan b ????????\n");

        Console.WriteLine("Value type (tipe data int)");
        int a = 5;
        int b = a;
        Console.WriteLine("Nilai awal dari a adalah = "+ a);
        Console.WriteLine("Nilai awal dari b adalah = "+ b);   //Contoh value Types are int, bool, double
        b = 8;
        Console.WriteLine("Nilai akhir dari a adalah = "+ a);
        Console.WriteLine("Nilai akhir dari b adalah = "+ b);
        int e = 5;
        ChangeValue(e);
        Console.WriteLine("Nilai setelah melalui method ChangeValue nilai a adalah = "+ e +"\n");

        Console.WriteLine("Reference type (Tipe data array)");        
        int[] c = { 5 };
        int[] d = c;
        Console.WriteLine("Nilai awal dari a adalah = "+ c[0]);
        Console.WriteLine("Nilai awal dari b adalah = "+ d[0]);    //Contoh value Types are int, bool, double
        d[0] = 8;
        Console.WriteLine("Nilai akhir dari a adalah = "+ c[0]);
        Console.WriteLine("Nilai akhir dari b adalah = "+ d[0]);

        int[] f = {5};
        ChangeValue(f);
        Console.WriteLine("Nilai setelah melalui method ChangeValue nilai a adalah = "+ f[0]);

        // var c = 3;
        // var d = 4;
        // var e = 5;
        // var f = 6;
        // var g = 7;
        // var h = 8;
    }
    static int ChangeValue(int x){
        return x = x + 1;
    }
    static int ChangeValue(int[] x){
        return x[0] = x[0] + 1;
    }
}