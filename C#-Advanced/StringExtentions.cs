using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    public static class StringExtentions
    {
        public static bool IsValidEmail( this string email )
        {
            // A very basic email validation for demonstration purposes
            return email.Contains( "@" ) && email.Contains( "." );
        }
    }
}
