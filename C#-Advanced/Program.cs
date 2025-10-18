
// 1. Extention Method
// Class Should be declared as static
// Method Should be declared as static
// this keyword is used in the first parameter to specify the type the method operates on
using C__Advanced;

int percentage = 5;
if ( percentage.IsBetween( 0, 100 ) )
{
    Console.WriteLine( $"{percentage} is between 0 and 100" );
}
else
{
    Console.WriteLine( $"{percentage} is not between 0 and 100" );
}

string email;
Console.WriteLine( "Enter an email address:" );
email = Console.ReadLine() ?? string.Empty;

if ( email.IsValidEmail() )
{
    Console.WriteLine( $"{email} is a valid email address" );
}
else
{
    Console.WriteLine( $"{email} is not a valid email address" );
}
