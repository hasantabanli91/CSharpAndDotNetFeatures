using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CSharpAndDotNetFeatures
{
    //  Const is nothing but "constant," a variable whose value is constant but at compile time.Therefore, it's mandatory to assign a value to it.
    //  By default, a const is static, and we cannot change the value of a const variable throughout the entire program.
    //  Readonly is the keyword whose value we can change during runtime or assign it at run time but only through the non-static constructor.
    public class ConstantAndReadonly
    {
        readonly int read = 10;
        const int cons = 10;
        public ConstantAndReadonly()
        {
            read = 100;
        }
        public void Check()
        {
            Console.WriteLine("Read only : {0}", read);
            Console.WriteLine("const : {0}", cons);
        }
    }
}
