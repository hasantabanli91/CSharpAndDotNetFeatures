﻿using System;

namespace CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n\n");

            #region Object Sample 

            #region For Class
            HumanClass human = new HumanClass(18, "Hasan");   //An object is an instance of a class. A class can have as many instances as needed. 
                                                              //For example Hasan and John is a instance of Human.

            human.Eat();

            HumanClass human2 = human;

            human2.Age = 17;                                  // Classes are reference types. So a variable of a class object holds a reference to the address of the object on the managed heap
            human2.Name = "John";                             // So output will Hasan(18) eating
                                                              //                John(17) eating
                                                              //                John(17) eating

            human.Eat();
            human2.Eat();

            Console.WriteLine("Class Object Sample Result\n\n");
            #endregion

            #region For Struct

            HumanStruct humanStruct = new HumanStruct(18, "Hasan");   //An object is an instance of a class. A class can have as many instances as needed. 
                                                                      //For example Hasan and John is a instance of Human.

            humanStruct.Eat();

            HumanStruct humanStruct2 = humanStruct;

            humanStruct2.Age = 17;                                  // Structs are value types. So a variable of a struct object holds a copy of the entire object
            humanStruct2.Name = "John";                             // So output will Hasan(18) eating
                                                                    //                Hasan(18) eating
                                                                    //                John(17) eating

            humanStruct.Eat();
            humanStruct2.Eat();

            Console.WriteLine("Struct Object Sample Result\n\n");
            #endregion

            Console.WriteLine("End Of Object Sample\n\n");

            #endregion

            #region Boxing, Unboxing Sample

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

            Console.WriteLine("End Of Boxing, Unboxing Sample\n\n");

            #endregion

            #region Pass by Value - Pass by Reference(Ref, Out) Sample

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

            Console.WriteLine("End Of Pass by Value - Pass by Reference(Ref, Out) Sample\n\n");

            #endregion

        }
    }
}