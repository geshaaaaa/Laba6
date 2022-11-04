using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab6t2
{
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {

        private struct IV
        {
            public TKey key;
            public TValue value;

            public IV(TKey? key, TValue? value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private IV[] arr;
        

        public MyDictionary()
        {
            arr = new IV[0];
            
        }
        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].key.Equals(key))
                    {
                        return arr[i].value;
                    }
                }
                return default(TValue);
            }
            set
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(key))
                    {
                        arr[i].value = value;
                    }
                }
            }
        }
        public void Add(TKey key, TValue value)
        {
           
            IV [] newarr = new IV[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];

            }            
            newarr[arr.Length] = new (key,value);
            arr = newarr;
            
        }
        public int Count { get { return arr.Length; } }
    }
}