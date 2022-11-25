using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Collection names = new Collection();
            names.Add("Yunus");
            names.Add("Emre");
            names.Add("Ahmed");
            names.Add("Beyza");
            names.Add(1);
            names.Add(2);

            foreach (object name in names)
                Console.Write($"({name}), ");

            Console.WriteLine("\nNumber of names: {0}", names.Count());

            Console.WriteLine("Deleted a item");
            names.Remove(2);
            Console.WriteLine("Number of names: {0}", names.Count());

            foreach (object name in names)
                Console.Write($"({name}), ");

            Console.WriteLine("\nRemoved the collection");
            names.Clear();
            Console.WriteLine("Number of names: {0}", names.Count());
            Console.ReadLine();
        }
    }
    public class Collection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }
        public void Remove(object item)
        {
            InnerList.Remove(item);
        }
        public new int Count()
        {
            return InnerList.Count;
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
    }
}
