using C__Advanced;


#region Extension Methods
// 1. Extention Method
// Class Should be declared as static
// Method Should be declared as static
// this keyword is used in the first parameter to specify the type the method operates on

//int percentage = 5;
//if (percentage.IsBetween( 0, 100 ))
//{
//    Console.WriteLine( $"{percentage} is between 0 and 100" );
//}
//else
//{
//    Console.WriteLine( $"{percentage} is not between 0 and 100" );
//}

//string email;
//Console.WriteLine( "Enter an email address:" );
//email = Console.ReadLine() ?? string.Empty;

//if (email.IsValidEmail())
//{
//    Console.WriteLine( $"{email} is a valid email address" );
//}
//else
//{
//    Console.WriteLine( $"{email} is not a valid email address" );
//}
#endregion


#region Recursion
// Recursion Example
//Console.WriteLine( "Enter a number to calculate its factorial:" );
//int number = int.Parse( Console.ReadLine() ?? "0" );
//int Factorial( int n )
//{
//    if (n <= 1)
//        return 1; // condition to end recursion
//    return n * Factorial( n - 1 ); // 5 * Factorial( 4 ) ==> 5 * 24 == 120

//    // Factorial using For loop
//    int factorial = 1;
//    for (int i = 2; i <= n; i++)
//        factorial *= i;

//    return factorial;

//}

//Console.WriteLine( $"Factorial of 5 is {Factorial( number )}" );



//static void PrintDirectoryContents( string path, int indentLevel = 0 )
//{
//    // Print the current directory
//    string indent = new string( '-', indentLevel * 2 );
//    Console.WriteLine( $"{indent}{Path.GetFileName( path )}/" );

//    // Print all files in the current directory
//    foreach (var file in Directory.GetFiles( path ))
//        Console.WriteLine( $"{indent}  {Path.GetFileName( file )}" );

//    // Recursively print subdirectories
//    foreach (var directory in Directory.GetDirectories( path ))
//        PrintDirectoryContents( directory, indentLevel + 1 );
//}


//string startPath = "D:\\portofolio";
//PrintDirectoryContents( startPath );


//static void CalculateDirectorySize( string path, ref long totalSize )
//{
//    // Add the size of all files in the current directory
//    foreach (var file in Directory.GetFiles( path ))
//    {
//        FileInfo fileInfo = new FileInfo( file );
//        totalSize += fileInfo.Length;
//    }
//    // Recursively calculate the size of subdirectories
//    foreach (var directory in Directory.GetDirectories( path ))
//        CalculateDirectorySize( directory, ref totalSize );

//}

//long totalSize = 0;
//CalculateDirectorySize( startPath, ref totalSize );
//Console.WriteLine( $"Total size of directory '{startPath}' is {totalSize} bytes." );
#endregion