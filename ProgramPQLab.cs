using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayPQ pq = new ArrayPQ();
            pq.Insert(5, "JP");
            pq.Insert(2, "XY");
            pq.Insert(3, "RK");
            pq.Insert(2, "AP");
            pq.Insert(4, "BB");
            pq.Insert(1, "CR");
            pq.Insert(6, "JG");
            pq.Insert(8, "RD");
            Entry temp = pq.RemoveMin();
            Console.WriteLine("Served: {0}", temp.Record);
            Console.WriteLine(pq.Size);
            temp = pq.Min();
            Console.WriteLine("Min: {0}", temp.Record);
            temp = pq.RemoveMin();
            Console.WriteLine("Served: {0}", temp.Record);
            Console.WriteLine(pq.Size);
            temp = pq.RemoveMin();
            Console.WriteLine("Served: {0}", temp.Record);
            Console.WriteLine(pq.Size);
            temp = pq.RemoveMin();
            Console.WriteLine("Served: {0}", temp.Record);
            Console.WriteLine(pq.Size);
            Console.ReadLine();
        }

        public class Entry
        {
            private int key;
            private object record;

            public int Key
            {
                get { return key; }
                set { key = value; }
            }

            public object Record
            {
                get { return record; }
                set { record = value; }
            }
        }

        public class ArrayPQ
        {
            private Entry[] list;
            private int count;
            private int minindex;


            public ArrayPQ()
            {
                list = new Entry[100];
                count = 0;
            }

            public Entry Insert(int k, object o)
            {
                list[count] = new Entry();
                list[count].Record = o;
                list[count].Key = k;
                count++;
                return null;
            }

            public Entry Min()
            {
                Entry min = list[0];
                minindex = 0;
                for (int i = 1; i < count; i++)
                {
                    if (list[i].Key < min.Key)
                    {
                        min = list[i];
                        minindex = i;
                    }
                }
                return min;
            }

            public Entry RemoveMin()
            {
                Min();
                Entry served = list[minindex];
                list[minindex] = null;
                for (int i = minindex; i <= count; i++)
                {
                    list[i] = list[i+1];
                }
                count--;
                return served;
            }

            public int Size
            {
                get { return count; }
            }
        }

    }
}
