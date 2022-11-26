using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection names = new Collection();

            #region Add
            names.Add("Yunus");
            names.Add("Emre");
            names.Add("Ahmed");
            names.Add("Beyza");
            names.Add(1);
            names.Add(2);
            PrintCollection(names);
            #endregion

            #region Count
            Console.WriteLine("\nNumber of names: {0}", names.Count());
            #endregion

            #region Remove
            Console.WriteLine("Deleted an item");
            names.Remove(2);
            PrintCollection(names);
            #endregion

            #region Insert
            Console.WriteLine("\nInsert an item after Ahmed");
            names.Insert(3, true);
            PrintCollection(names);
            #endregion

            #region Contains
            Console.WriteLine("\nContain is 'Emre' in Collection(returns True or False)\n{0}", names.Contains("Emre"));
            #endregion

            #region IndexOf
            Console.WriteLine("Index of '1' in Collection\n{0}", names.IndexOf(1));
            #endregion

            #region RemoveAt
            Console.WriteLine("Remove at first index in the Collection");
            names.RemoveAt(0);
            PrintCollection(names);
            #endregion

            #region Clear
            Console.WriteLine("\nRemoved the Collection");
            names.Clear();
            #endregion

            Console.ReadLine();
        }

        static void PrintCollection(Collection names)
        {
            foreach (object name in names)
                Console.Write($"({name}), ");
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
        public void Insert(int index, object item)
        {
            InnerList.Insert(index, item);
        }
        public bool Contains(object item)
        {
            return InnerList.Contains(item);
        }
        public int IndexOf(object item)
        {
            return InnerList.IndexOf(item);
        }
        public new void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }
    }
}
