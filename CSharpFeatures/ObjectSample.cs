using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAndDotNetFeatures
{
    internal class ObjectSample
    {
        public void ObjectSampleMethod()
        {
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
        }


    }
}
