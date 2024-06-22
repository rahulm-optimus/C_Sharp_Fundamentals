namespace KeywordsAndIdentifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //all reserved words to define the type of variables of item is keyword
            //int string bool new class virtual override interface .....etc. are keywords

            //name of the variable is identitifier
            Console.WriteLine("Enter your name and age ");

            string Name = Console.ReadLine();
            Console.WriteLine($"My name is {Name}");

            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"My age is {Age}");


        }
    }
}
