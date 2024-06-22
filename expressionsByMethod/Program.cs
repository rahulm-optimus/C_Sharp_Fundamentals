namespace expressionsByMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [5, 10, 8, 3, 6, 12];

            IList<int> numQuery = numbers;

            var sortedByEvenNumber =numbers.Select(x=>x).Where(x=>x%2==0).OrderBy(x=>x);

            foreach (int i in sortedByEvenNumber)
            {
                Console.Write(i + " ");
            }
        }
    }
}
