namespace GenericsCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region List
            List<int> GenericList = new List<int>();

            GenericList.Add(30);

            GenericList.Add(60);

            GenericList.Add(90);

            GenericList.Add(120);

            foreach (int x in GenericList)

            {

                Console.WriteLine(x);

            }

            #endregion

            #region  Dictionary

            Dictionary<int, string> GenericDictionary = new Dictionary<int, string>();

            GenericDictionary.Add(1, "Soda");

            GenericDictionary.Add(2, "Burger");

            GenericDictionary.Add(3, "Fries");

            GenericDictionary.Add(4, "Onion Rings");

            foreach (KeyValuePair<int, string> kvp in GenericDictionary)

            {

                Console.WriteLine(kvp.Key + " " + kvp.Value);

            }
            #endregion

            #region Shorted List
            SortedList<string, string> GenericSortedList = new SortedList<string, string>();

            GenericSortedList.Add("American", "Burger");

            GenericSortedList.Add("Lime", "Soda");

            GenericSortedList.Add("French", "Fries");

            GenericSortedList.Add("Onion", "Rings");

            foreach (KeyValuePair<string, string> kvp in GenericSortedList)

            {

                Console.WriteLine(kvp.Key + " " + kvp.Value);

            }
            #endregion

            #region Stack --LIFO
            Stack<string> steak = new Stack<string>();

            steak.Push("Rare");

            steak.Push("Medium Rare");

            steak.Push("Medium");

            steak.Push("Well done");

            foreach (string s in steak)

            {

                Console.WriteLine(s);

            }
            #endregion

            #region Queue --FIFO

            Queue<string> GenericQueue = new Queue<string>();

            GenericQueue.Enqueue("Mark");

            GenericQueue.Enqueue("Bill");

            GenericQueue.Enqueue("Xavier");

            GenericQueue.Enqueue("Michael");

            foreach (string s in GenericQueue)

            {

                Console.WriteLine(s);

            }

            #endregion

        }
    }
}
