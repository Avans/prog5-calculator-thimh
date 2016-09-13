using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AgeCalc
    {
        public int CalculateAge(DateTime result)
        {
            if (result.CompareTo(DateTime.Now) == -1)
            {
                TimeSpan difference = DateTime.Now - result;
                int age = (int)(difference.TotalDays / 365.25);
                return age;
            } else
            {
                return 0;
            }
        }
    }
}
