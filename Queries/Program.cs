namespace Queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [5, 10, 8, 3, 6, 12];

            Console.WriteLine("All numbers without query ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            IEnumerable<int> numQuery1 =
                            from num in numbers
                            where num % 2 == 0
                            orderby num
                            select num;
            Console.WriteLine("All even numbers after query");
            foreach (int num in numQuery1) 
            {
            Console.WriteLine(num);
            }
        }
    }
}
