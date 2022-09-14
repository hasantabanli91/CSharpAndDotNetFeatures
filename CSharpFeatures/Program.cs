using System;

namespace CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n\n");

            #region Object Sample

            ObjectSample objectSample = new ObjectSample();
            objectSample.ObjectSampleMethod();

            Console.WriteLine("End Of Object Sample\n\n");

            #endregion

            #region Boxing, Unboxing Sample

            BoxingUnboxingSample boxingUnboxingSample = new BoxingUnboxingSample();
            boxingUnboxingSample.BoxingUnboxing();

            Console.WriteLine("End Of Boxing, Unboxing Sample\n\n");

            #endregion

            #region Pass by Value - Pass by Reference(Ref, Out) Sample

            PassByValuePassByReferenceRefOutSample passByValuePassByReferenceRefOutSample = new PassByValuePassByReferenceRefOutSample();
            passByValuePassByReferenceRefOutSample.RefOut();
            Console.WriteLine("End Of Pass by Value - Pass by Reference(Ref, Out) Sample\n\n");

            #endregion

        }
    }
}
