// using Internal;
// using System.Runtime.ConstrainedExecution;
// using System.Threading;
// using System;
namespace ThreadingCallback
{
    public delegate void ResultCallback(int result);
    public class Number
    {
        private int _number;
        public ResultCallback _resultCallback;
        public Number(int number, ResultCallback resultCallback)
        {
            _number = number;
            _resultCallback = resultCallback;
        }
        public void Sum()
        {
            int result = 0;
            for (int i = 0; i < _number; i++)
            {
                result += i;
            }
            if (_resultCallback != null)
            {
                _resultCallback(result);
            }
        }
    }
    class Program
    {
        static void Main(string[] args){
            ResultCallback myResultCallback = new ResultCallback(resultCallbackMethod);
            int number = 10;
            Number obj = new Number(number, myResultCallback);
            Thread t1 = new Thread(new ThreadStart(obj.Sum));
            t1.Start();
            Console.Read();
        }
        public static void resultCallbackMethod(int result)
        {
            Console.WriteLine("The result is " + result);
        }
    }
}


