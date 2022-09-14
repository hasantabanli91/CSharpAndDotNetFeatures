using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    internal class BoxingUnboxingSample
    {
        public void BoxingUnboxing()
        {
            // Boxing : The process of converting from a value type to a reference type is called boxing.
            //          When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap
            int number = 123;
            Object obj = number;
            Console.WriteLine(number + "\n");
            Console.WriteLine(obj + "\n");

            // Unboxing : The process of converting from a reference type to a value type is called unboxing.
            //            Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit
            Object obj2 = 123;
            int number2 = (int)obj;
            Console.WriteLine(number2 + "\n");
            Console.WriteLine(obj + "\n");

            // In relation to simple assignments, boxing and unboxing are computationally expensive processes.
            // When a value type is boxed, a new object must be allocated and constructed.
        }
    }
}
