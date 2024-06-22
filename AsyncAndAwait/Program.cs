namespace AsyncAndAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {




            static async Task<string> WashingClothes()
            {
                Console.WriteLine("thread ID  {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Washing started");
                await Task.Delay(6000);
                return "Washing is Finished";
            }

            static async Task<string> Cooking()
            {
                Console.WriteLine("thread ID  {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Cooking started");
                await Task.Delay(4000);
                return "Cooking Finished";
            }

            static async Task<string> Cleaning()
            {
                Console.WriteLine("thread ID  {0}", Thread.CurrentThread.ManagedThreadId);
                throw new Exception("cleaning machine is not working");
                Console.WriteLine("Cleaning started");
               await  Task.Delay(8000);
                return "Cleaning Finished";
            }

            try {
                
                Cleaning(); ;
                WashingClothes().Wait();
                Cooking();
            }
            catch(Exception ex)
            {
                Console.WriteLine("expection being thrown because"+ ex.Message);


            }







        }


    }
}
