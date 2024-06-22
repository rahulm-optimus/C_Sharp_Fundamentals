namespace ConditionalAndIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else if else
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            #endregion

            #region switch
            int day = 10;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not applicable");
                    break;
            }

            #endregion

            #region While
            string? quitWhile;
            quitWhile = Console.ReadLine();
            while (quitWhile != "quit")
            {
                quitWhile = Console.ReadLine();
                Console.WriteLine("Will stop after getting the right false condition");

            }
            #endregion

            #region Do while

            do
            {
                Console.WriteLine("Do this untill gets false");
            } while (false);
            #endregion

            #region Short Hand
            var result = true ? "Condition 1 If it's true" : "condition 2nd if it's false";
            Console.WriteLine(result);
            #endregion

            #region for loop
            for (int i = 0; i < 5; i++)
            {

                if (i == 2) { continue; } else if (i == 4) { break; } else { Console.WriteLine(i); }

            }
            #endregion

            #region foreach
            int[] IntArray = { 1, 2, 3, 4, 5 };

            foreach (int i in IntArray)
            {
                Console.WriteLine(i);
            }
            #endregion

        }
    }
}
