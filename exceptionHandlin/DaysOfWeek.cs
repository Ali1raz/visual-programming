using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlin
{
    internal class DaysOfWeek
    {
        private string[] days = { "Sunday", "Monday", "Tuesday", "Thursday", "Friday", "Saturday" };

        public string this[int index]
        {
            get
            {
                if (index <0 || index >= days.Length) throw new IndexOutOfRangeException($"Invalid index: {index}, must be 0 to 6");
                return days[index];
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < days.Length; i++)
                {
                    if (days[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return i;
                    }
                }
                throw new ArgumentException($"invalid day name: {name}");
            }
        }
    }
}
