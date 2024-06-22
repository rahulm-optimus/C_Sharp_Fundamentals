namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<int> age = new Student<int>(2);
            Student<string> name = new Student<string>("Rahul");

            Console.WriteLine($" Generic values of Student class : {age} {name}");


        }
        public class Student<T>
        {
            // define a variable of type T 
            public T data;

            // define a constructor of the Student class 
            public Student(T data)
            {
                this.data = data;
                Console.WriteLine("Data passed: " + this.data);
            }
        }
    }
}
