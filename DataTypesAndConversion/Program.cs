namespace DataTypesAndConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Data types

            //Numeric
            // // declaring character 
            char a = 'G';

            // Integer data type is generally 
            // used for numeric values 
            int i = 89;

            short s = 56;

            // this will give error as number 
            // is larger than short range 
            // short s1 = 87878787878; 

            // long uses Integer values which  
            // may signed or unsigned 
            long l = 4564;

            // UInt data type is generally 
            // used for unsigned integer values 
            uint ui = 95;

            ushort us = 76;
            // this will give error as number is 
            // larger than short range 

            // ulong data type is generally 
            // used for unsigned integer values 
            ulong ul = 3624573;

            // by default fraction value 
            // is double in C# 
            double d = 8.358674532;

            // for float use 'f' as suffix 
            float f = 3.7330645f;

            // for float use 'm' as suffix 
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);


            // boolean data type 
            bool b = true;
            if (b == true)
                Console.WriteLine("It's true and data type used is boolean");


            // declaring string 
            string String = "String";

            //append in a 
            String += "Add";
            String = String + "AnotherString";
            Console.WriteLine(String);

            // declare object obj 
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object 
            // using GetType() 
            Console.WriteLine(obj.GetType());

            #endregion


            #region Conversions

            //implicit

            object implicitType = 2;
            Console.WriteLine(implicitType.GetType());

            int IntValue = 23;
            float floatValue = IntValue;
            Console.WriteLine($"{IntValue} - Implicitily changed the type without data loss :{floatValue}");

            //explicit
            float floatValue2 = 23.23f;
            int IntValue2 = (int)floatValue2;
            Console.WriteLine($"{floatValue2} - Explicitily changed the type with data loss :{IntValue2}");

            //explicit-Covert
            string IntValue3 = "23";
            Console.WriteLine($"{IntValue3} - Explicitilty changing string value to int {Convert.ToInt32(IntValue3)}");

            //parse
            string StringIntValue = "54";

            bool BoolValue = int.TryParse(StringIntValue, out int IntValue4);

            var result = BoolValue ? "Can be convertible" : "Not convertible";
            Console.WriteLine(result);

            #endregion

        }

    }
}
