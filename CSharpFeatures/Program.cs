using System;

namespace CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Object Sample 
            Human human = new Human();  //An object is an instance of a class. A class can have as many instances as needed. 
            human.Age = 18;             //For example Hasan and John is a instance of Human.
            human.Name = "Hasan";

            Human human2 = new Human();
            human2.Age = 17;
            human2.Name = "John";

            human.Eat();
            human.Sleep();
            human2.Eat();
            human2.Sleep();
            #endregion
        }
    }
}
