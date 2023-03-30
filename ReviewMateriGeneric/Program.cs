// GENEGRIC
// ARRAYLIST
// IF else
// instance 
//CRUDe



using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        DataStore._capasity = 5;
        DataStore mylist = new DataStore();
        DataStore my2ndlist = new DataStore();
        mylist.AddData("jammys");
        mylist.AddData(2);
        my2ndlist.AddData("1.Mikey");
        my2ndlist.AddData("2.Jhony");
        my2ndlist.AddData("3.Brody");
        my2ndlist.AddData("4.Jhony");
        my2ndlist.AddData("5.Brody");
        my2ndlist.AddData("5.Brody");
        Console.WriteLine("\ndata yang kamu panggil di array 1");
        mylist.GetData(); //
        Console.WriteLine("The number of data in the list is " + mylist.Count()+"\n");
        Console.WriteLine("2nd data yang kamu panggil");
        my2ndlist.GetData(); //
        my2ndlist.RemoveData("ikey");
        my2ndlist.RemoveData("1.Mikey");
        Console.WriteLine("the number of data in @nd list is " + my2ndlist.Count());

    }

    class DataStore{
        public static int _capasity;
        public int Count (){
            return _data.Count;
        }
        public ArrayList _data = new ArrayList(_capasity);
        public void AddData <T> (T data){
            if(_data.Count < _capasity)
            {
                _data.Add(data);
            }
            else
            {
                Console.WriteLine("YOU CANNOT ADD MORE THAN " + _capasity + " data");
            }
        }
        public void RemoveData<T>(T data){

            if (_data.Contains(data))
            {
                _data.Remove(data);
                Console.WriteLine("DATA HAS BEEN REMOVED !!!!");
            }
            else
            {
                Console.WriteLine("You cannot remove because " + data + " is not in the list.");
            }
        }
        public void GetData(){
            foreach(var item in _data) 
            Console.WriteLine(item); 
        }
    }
}
    
