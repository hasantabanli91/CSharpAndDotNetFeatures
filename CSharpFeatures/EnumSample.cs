using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharpFeatures
{
    public class EnumSample
    {
        public void GetMonths()
        {
            string[] values = Enum.GetNames(typeof(MonthsEnum));

            foreach (string s in values)
            {
                Console.WriteLine(s);
            }

            int[] n = (int[])Enum.GetValues(typeof(MonthsEnum));
            foreach (int x in n)
            {
                Console.WriteLine(x);
                Console.WriteLine(Extension.GetEnumDescription((MonthsEnum)x));
            }
            Console.ReadLine();
        }
    }

    public static class Extension
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }
    }
    public enum MonthsEnum
    {
        [Description("January")]
        January = 1,
        [Description("Fabruary")]
        Fabruary = 2,
        [Description("March")]
        March = 3,
        [Description("April")]
        April = 4,
        [Description("May")]
        May = 5,
        [Description("June")]
        June = 6,
        [Description("July")]
        July = 7,
        [Description("August")]
        August = 8,
        [Description("September")]
        September = 9,
        [Description("October")]
        October = 10,
        [Description("November")]
        November = 11,
        [Description("December")]
        December = 12
    }
}
