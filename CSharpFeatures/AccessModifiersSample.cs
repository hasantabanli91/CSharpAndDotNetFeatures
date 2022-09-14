using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    internal class Car : Vehicle //: SealedClass > When we try that we take en error like "cannot derive from sealed type"
    {   // Internal keyword is used access the class in this solution
        private string model = "Mustang";

        public void CarSample()
        {
            Car car = new Car();
            Console.WriteLine(car.model);

            car.Drive(); // We can use Drive Method because of we inherite it

            //Motorcycle motorcycle = new Motorcycle(); > When we try this, we take an error like "Cannot create an instance of static class"
            Motorcycle.GetLicenceForMotorcycle();
        }
    }

    static class Motorcycle // Static Class cannot inherite. They can take only static members. We have to use static keywords for define new member.
    {                       // Cannot create an instance of static class
        public static void GetLicenceForMotorcycle()
        {
            Console.WriteLine("You got Motorcycle Licence");
        }
    }

    sealed class SealedClass // We cannot inherite sealed class
    {
    }

    public class Vehicle
    {
        protected void Drive()
        {
            Console.WriteLine("Drive your vehicle");
        }
    }
}
