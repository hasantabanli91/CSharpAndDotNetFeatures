using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAndDotNetFeatures
{
    internal class PassByValuePassByReferenceRefOutSample
    {
        public void RefOut()
        {
            int aNumber;
            string anotherNumber = "5";

            // Ref and out keywords in C# are used to pass arguments within a method or function. Both indicate that an argument/parameter is passed by reference
            // out dont have to have first value, but ref have to.

            int.TryParse(anotherNumber, out aNumber);

            Console.WriteLine("First Value: {0}", aNumber);
            Square(aNumber); // Pass by Value : Value isnt change before and after the method. Pass a copy of the original value to the function rather than reference.
            Console.WriteLine("After Square(): {0}", aNumber);
            SquareRef(ref aNumber); // Reference by Value : Value changed in function. Because we passes a reference of arguments to the function with ref or out. The changes in passed values are permanent and modify the original variable values
            Console.WriteLine("After Square2(): {0}", aNumber);
        }

        static void Square(int anumber)
        {
            anumber = anumber * anumber;
            Console.WriteLine("Inside Square Function: {0}", anumber);
        }

        static void SquareRef(ref int anumber)
        {
            anumber = anumber * anumber;
            Console.WriteLine("Inside SquareRef Function: {0}", anumber);
        }
    }
}
