namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pigInsta = new Pig();
            pigInsta.animalSound();
        }

        interface IAnimal
        {
            void animalSound(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        class Pig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

    }
}
