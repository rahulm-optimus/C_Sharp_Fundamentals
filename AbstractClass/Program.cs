namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat();
            animal.sleep();
        }

        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public virtual void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Cat : Animal
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The Cat says: meow meow");
            }

            public override void  sleep()
            {
                Console.WriteLine("geezzz");            }
        }
    }
}
