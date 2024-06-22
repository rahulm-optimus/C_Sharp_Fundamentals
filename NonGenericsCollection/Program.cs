using System.Collections;

namespace NonGenericsCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array List
            ArrayList NonGenericArrayList = new ArrayList();

            string str = "Like, Share, Subscribe";

            int x = 11;

            DateTime d = DateTime.Parse("3-dec-1998");

            NonGenericArrayList.Add(str);

            NonGenericArrayList.Add(x);

            NonGenericArrayList.Add(d);

            foreach (object o in NonGenericArrayList)

            {

                Console.WriteLine(o);

            }
            #endregion

            #region Hastable

            Hashtable NonGenericHashTable = new Hashtable();

            NonGenericHashTable.Add(1, "Soda");

            NonGenericHashTable.Add(2, "Burger");

            NonGenericHashTable.Add(3, "Fries");

            NonGenericHashTable.Add(4, "Onion Rings");

            foreach (DictionaryEntry h in NonGenericHashTable)

            {

                Console.WriteLine(h.Key + " " + h.Value);

            }
            #endregion

            #region Shorted List 
            SortedList NonGenericSortedList = new SortedList();

            NonGenericSortedList.Add("American", "Burger");

            NonGenericSortedList.Add("Lime", "Soda");

            NonGenericSortedList.Add("French", "Fries");

            NonGenericSortedList.Add("Onion", "Rings");

            foreach (DictionaryEntry val in NonGenericSortedList)

            {

                Console.WriteLine(val.Key + " " + val.Value);

            }
            #endregion

            #region Stack
            Stack steak = new Stack();

            steak.Push("Rare");

            steak.Push("Medium Rare");

            steak.Push("Medium");

            steak.Push("Well done");

            foreach (object o in steak)

            {

                Console.WriteLine(o);

            }
            #endregion

            #region Queue
            Queue NonGenericQueue = new Queue();

            NonGenericQueue.Enqueue("Mark");

            NonGenericQueue.Enqueue("Bill");

            NonGenericQueue.Enqueue("Xavier");

            NonGenericQueue.Enqueue("Michael");

            foreach (object o in NonGenericQueue)

            {

                Console.WriteLine(o);

            }
            #endregion





        }
    }
}
