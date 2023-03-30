//PERBEDAAN VAR DAN DYNAMIC
//var seolah" menjadi suatu type data tertentu ketika pertama diinisialilasasi 
//dan tidak bisa dirubah value nya dengan type data lain
//dynamic bisa valuenya dapat berubah terus dan tidak terikat dengan inisialisasi awal seperti var

using System.Globalization;
using System.Net.WebSockets;

Console.WriteLine("Ini adalah type data var");
var varType = "mike";
Console.WriteLine("Ini adalah value inisialisasi awal dari var = "+varType);
varType = "Leo";
Console.WriteLine("mengubah value dengan type data yang sama var = "+varType);
// varType = 6; akan menyebabkan Error karena variable varType telah di set menjadi string
Console.WriteLine("Value tidak dapat dirubah ke type data lain\n");

Console.WriteLine("Ini adalah type data dynamic");
dynamic dynamicType = "mike";
Console.WriteLine("Ini adalah value inisialisasi awal dari var = "+dynamicType);
dynamicType = "Leo";
Console.WriteLine("mengubah value dengan type data yang sama dynamic = "+dynamicType);
dynamicType = 6; 
Console.WriteLine("mengubah value dengan type data yang BERBEDA dynamic = "+dynamicType);
