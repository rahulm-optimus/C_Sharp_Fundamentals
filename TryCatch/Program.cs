using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //There are two types of exception 
            //1- system 2-Application

            //1	  System.IO.IOException
            //    Handles I/ O errors.
            //2   System.IndexOutOfRangeException
            //    Handles errors generated when a method refers to an array index out of range.
            //3   System.ArrayTypeMismatchException
            //    Handles errors generated when type is mismatched with the array type.
            //4   System.NullReferenceException
            //    Handles errors generated from referencing a null object.
            //5   System.DivideByZeroException
            //    Handles errors generated from dividing a dividend with zero.
            //6   System.InvalidCastException
            //    Handles errors generated during typecasting.
            //7   System.OutOfMemoryException
            //    Handles errors generated from insufficient free memory.
            //8   System.StackOverflowException
            //    Handles errors generated from stack overflow.

            

            int number = 18;

            try
            {
                int value = Convert.ToInt32(Console.ReadLine());
                CustomeException exception = new CustomeException(value);

                int result = number / exception.value;
                Console.WriteLine(result);



            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number divisible by zero is infinity");
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);

            }
            finally
            {
                Console.WriteLine("It always executes");
            }
        }

        class CustomeException : ApplicationException
        {
            public int value { get; set; }

            public CustomeException(int value)
            {
                this.value = value;
                if (this.value > 20)
                {
                    throw new Exception("Error: Number greater than  20 is not executable ");

                }
            }
        }
    }
}
