using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1.MeList
{
    public class MeList<T> : IEnumerable<T>
    {
        T[] items;
        public MeList(int capacity = 5)
        {
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if(Count == items.Length)
            {
               Array.Resize(ref items, items.Length * 2);
                
            }
            items[Count++] = item;
        }

        public void Clear()
        {
            for(int i = 0; i < Count; i++)
            {
                items[i] = default(T);
            }
            Count = 0;
        }

        public void TrimExcess()
        {
            T[] newArray = new T[Count];
            Array.Copy(items, newArray, Count);
            items = newArray;
        }

        public void Add(T[] arr)
        {
             foreach(T value in arr)
             {
                 Add(value); 
             }
            
        }

        public T this[int index]
        {
            get
            {
                CheckBoundaries(index);
                return items[index];
            }
            set
            {
                CheckBoundaries(index);
                items[index] = value;
            }
        }

        public int Capacity
        {
            get { return items.Length; }
        }
        public int Count { get; private set; }
        private void CheckBoundaries(int index)
        {
            if (index >= Count && index < 0)
                throw new IndexOutOfRangeException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetInternalArrayLength()
        {
            return items.Length;
        }
        public void PrintList()
        {
            foreach(T item in this.items)
            {
                Console.WriteLine(item);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
