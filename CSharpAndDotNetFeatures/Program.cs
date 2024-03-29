﻿using System;
using System.Collections.Generic;

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

            #region Yield Sample
            Yield yield = new Yield();
            IEnumerable<string> datas = yield.BringDaysWithYield();

            foreach (var item in datas)
                Console.WriteLine(item);

            datas = yield.BringDays();

            foreach (var item in datas)
                Console.WriteLine(item);

            #endregion

            #region ConstantReadonly Sample

            ConstantAndReadonly constantAndReadonly = new ConstantAndReadonly();
            constantAndReadonly.Check();

            #endregion

            //TODO delegate event invoke
            #region Delegate 
            Delegates delegateOperations = new Delegates();
            Delegates.MathFourOperationsHandler mathFourOperationsHandler = new Delegates.MathFourOperationsHandler(delegateOperations.Sum);
            Console.WriteLine("Delegate Operation Sum of 10 and 5" + mathFourOperationsHandler(10, 5));
            Console.WriteLine("Delegate Operation Sum of 10 and 15 with Invoke Method " + mathFourOperationsHandler.Invoke(10, 15));
            #endregion

            //TODO https://github.com/dotnet/try-samples/tree/main/101-linq-samples/src for linq

            //TODO csharp features, new features will seperate with files
        }
    }
}
