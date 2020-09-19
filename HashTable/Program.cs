using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashTable ht = new MyHashTable(100);
            ht.addItem("test");
            ht.addItem("hhhhh");
            ht.printItems();
        }
    }

    public class MyHashTable
    {
        private Object[] list;
        private int size;

        public MyHashTable(int size=10)
        {
            this.list = new Object[size];
            this.size = size;
        }

        public int getSize()
        {
            return this.size;
        }

        public void addItem(object o)
        {
            int code = o.GetHashCode();
            Console.WriteLine("code:" +code);

            if (code < 0)
                code = code * -1;

            int index = (code) % (list.Length);
            Console.WriteLine("index:" + index);

            list[index] = o;
        }

        public void printItems()
        {
            foreach(object obj in list)
            {
                if(!(obj is null))
                    Console.WriteLine(obj.ToString());
            }
            
        }
    }
}
