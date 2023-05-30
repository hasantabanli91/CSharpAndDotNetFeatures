using System;

namespace CSharpAndDotNetFeatures
{
    internal class Program
    {
        static void Main(string[] args) // When a method doesnt need to return a value, we use the void keyword.
        {
            Console.WriteLine("Hello World! \n\n");

            #region Object Sample

            ObjectSample objectSample = new ObjectSample(); // we use "new" keyword when we want to create an instance of class or struct.
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

            #region AccessModifiersSample

            Car car = new Car();
            // car.Model > we cannot use private members another classes
            // car.Drive() > we cannot use protected members unless we inherite its class in this class

            car.CarSample(); // we can access CarSample Method because it is public.

            Console.WriteLine("End Of Access Modifiers(with static, sealed) Sample\n\n");
            #endregion

            #region EnumSample

            EnumSample enumSample = new EnumSample();
            enumSample.GetMonths();

            #endregion

            //TODO async await
        }
    }
}
