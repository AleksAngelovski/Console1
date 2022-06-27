using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1.MeList
{
    public class MeList<T>
    {
        T[] items = new T[5];
        public int count { get; set; }
        public void Add(T item)
        {
            if(count == items.Length)
            {
               Array.Resize(ref items, items.Length * 2);
                
            }
            items[count++] = item;
        }
        public void Add(T[] arr)
        {
             foreach(T value in arr)
             {
                 Add(value); 
             }
            
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
    }
}
