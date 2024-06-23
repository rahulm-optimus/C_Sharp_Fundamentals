namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pathName = @"C:\Users\rahul.mehra\OneDrive - Optimus Information Inc\Desktop\directory\24thjune2024.txt";

            if (!File.Exists(pathName))
            {
                Console.WriteLine("File does not exist");
            }
            else
            {
                //to read a file
                string content = File.ReadAllText(pathName);
                Console.WriteLine(content);
            }

            string pathName2 = @"C:\Users\rahul.mehra\OneDrive - Optimus Information Inc\Desktop\directory\sample.txt";
            //creating a file 
            File.WriteAllText(pathName2, "Hello World");

            if (File.Exists(pathName2)) Console.WriteLine(File.ReadAllText(pathName2));

            //Appending in sample.txt

            if (File.Exists(pathName2)) File.AppendAllText(pathName2, "\n Next content " + Environment.NewLine);
            string insertingValue = Console.ReadLine();

            do
            {

                if (File.Exists(pathName2)) File.AppendAllText(pathName2, $"\n - {insertingValue}" + Environment.NewLine);
                insertingValue = Console.ReadLine();
            } while (insertingValue != "quit");






        }
    }
}
