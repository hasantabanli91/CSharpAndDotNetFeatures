using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{

    public class HumanClass : IHuman //,HumanStruct > When we try that we take an error like this "Error	CS0527	Type 'HumanStruct' in interface list is not an interface"
    // Classes are Reference Types. Reference Types are kept in Heap.
    {                       // When we need pass big values to methods, we pass their reference with classes. so we avoid to use unnecessary memory
        public int Age;     // Classes can inherited
        public string Name;

        public HumanClass(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " eating\n");
        }
        public void Sleep()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " sleeping\n");
        }
    }

    public struct HumanStruct : IHuman
    {                         // Structs are Value Types. Value Types are kept in Stack
        public int Age;       // If we use low data(Generally less than 16 byte) we use struct. So we work faster.
        public string Name;   // Structs cannot inherite.

        public HumanStruct(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " eating\n");
        }
        public void Sleep()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " sleeping\n");
        }
    }

    public interface IHuman
    {
        void Eat();
        void Sleep();
    }
}
