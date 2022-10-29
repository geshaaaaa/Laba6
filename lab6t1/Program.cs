using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zavd;

namespace lab6t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMylist<int> mylist = new Mylist<int>();
            Console.WriteLine("Додати до массиву елемент(и):");
            int a;
            a = int.Parse(Console.ReadLine());
            mylist.Add(a);
            Console.WriteLine("Всього елементів в масиві:");
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i]);
                
            }



        }


    }
}
