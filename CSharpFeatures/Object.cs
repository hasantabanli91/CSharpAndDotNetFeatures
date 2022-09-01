using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class Human
    {
        public int Age;
        public string Name;

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
