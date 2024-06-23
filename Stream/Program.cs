namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathName = @"C:\Users\rahul.mehra\OneDrive - Optimus Information Inc\Desktop\directory\sampleStream.txt";


            //stream writing
            using (var writer = new StreamWriter(
           new FileStream(pathName, FileMode.Create)))
            {
                writer.Write("Beep bop!");
            }

            //stream reading
            using (var reader = new StreamReader(
                new FileStream(pathName, FileMode.Open)))
            {
                Console.WriteLine(reader.ReadToEnd());
            }



        }
    }
}
