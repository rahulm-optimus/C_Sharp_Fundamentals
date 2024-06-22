namespace ClassAndConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();

            Console.WriteLine("Employee default values : {0} - {1}",employee.Id,employee.Name);    
            
        }

         class Employee 
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public Employee()
            {
                Id = 1;
                Name = "Test";
            }
        }
    }
}
