using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAndDotNetFeatures
{
    public class Yield
    {
        public IEnumerable<string> BringDaysWithYield()
        {
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
            yield return "Thursday";
            yield return "Friday";
            yield return "Saturday";
            yield return "Sunday";
        }

        public IEnumerable<string> BringDays()
        {
            string[] Days = { "Sunday", "Saturday", "Friday", "Thursday", "Wednesday", "Tuesday", "Monday" };
            List<string> days = new List<string>();
            foreach (var Day in Days)
                days.Add(Day);
            return days;
        }
    }
}
