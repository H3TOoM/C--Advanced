using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    public static class IntExtentions
    {
        public static bool IsBetween( this int number, int lowerBound, int upperBound )
        {
            return number >= lowerBound && number <= upperBound;
        }
    }
}
