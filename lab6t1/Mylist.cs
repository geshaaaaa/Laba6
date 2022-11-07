using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zavd;
namespace zavd
{
    class Mylist<T> : IMylist<T>
    {

        T[] arr = Array.Empty<T>();


        public T this[int index]
{
            get
            { return arr[index]; }
            set
            { arr[index] = value; }

        }

        public void Add(T value)
        {

            T[] newarr = new T[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[arr.Length] = value;
            arr = newarr;
        }

        

        public int Count { get { return arr.Length; } }

        


    }
}
