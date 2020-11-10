using DataServiceLib;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IDataService ds = new DataService();
            Console.WriteLine(ds.GetTitles().Count);
        }
    }
}
