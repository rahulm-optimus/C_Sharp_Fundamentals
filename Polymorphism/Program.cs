namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            Console.WriteLine("Here refernce is genrated from dog class where run time change is done");
            animal.animalSound();
            Console.WriteLine("Here no runtime is change for the base class method");
            Animal animal2 = new Pig();
            animal2.animalSound();
            
        }

        class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }
    }
}
