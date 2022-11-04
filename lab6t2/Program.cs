using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---- MyDictionary<int, string>() ---\n");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            Console.WriteLine("Ключ для виовду:A=1,B=2,C=3");
            int a, b, c;
            Console.WriteLine("Введіть ключ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ключ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ключ");
            c = int.Parse(Console.ReadLine());
            myDictionary.Add(a, "A");
            myDictionary.Add(b, "B");
            myDictionary.Add(c, "C");
            Console.WriteLine($"Доданий елемент:{myDictionary[1]}");
            Console.WriteLine($"Доданий елемент:{myDictionary[2]}");
            Console.WriteLine($"Доданий елемент:{myDictionary[3]}");
            Console.WriteLine($"Додано елментів {myDictionary.Count}");
            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine(myDictionary[i]);
            }
        }




    }
}
