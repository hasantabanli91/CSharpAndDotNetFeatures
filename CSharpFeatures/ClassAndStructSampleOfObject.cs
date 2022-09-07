using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class HumanClass
    {
        public int Age;
        public string Name;

        public HumanClass(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " eating");
        }        
        public void Sleep()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " sleeping");
        }
    }

    public struct HumanStruct
    {
        public int Age;
        public string Name;

        public HumanStruct(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " eating");
        }
        public void Sleep()
        {
            Console.WriteLine(Name + "(" + Age + ")" + " sleeping");
        }
    }
}
