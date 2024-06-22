namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic class instance
            GenericClass<string> genericClass = new GenericClass<string>();
            genericClass.Value = "value";
            string result =genericClass.Print();
            Console.WriteLine(result);


        }


        #region Generic class
        class GenericClass<T>
        {
            public T Value { get; set; }

            public T Print() { return Value; }
        }
        #endregion

    }
}
