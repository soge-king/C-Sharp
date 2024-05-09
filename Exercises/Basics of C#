
//this is a one line comment

/*
this is a multi line comment

*/

//to start here is a basic examplem of variables and how to assign them, it should also be inittialized (i.e. not be empty)
string firstName = "Bob";
int messages = 3;
var degrees_temp = 34.4;
// the 'var' key word is used to basically make a var your not sure how to use yet.
//if you know what data type the variable is then use the folowing:
/*
- `string` for words, phrases, or any alphanumeric data for presentation, not calculation
- `char` for a single alphanumeric character
- `int` for a whole number
- `decimal` for a number with a fractional component
- `bool` for a `true`/`false` value

*/

// to put variables inside a string output
Console.Write($"Hello, {firstName}! You have {messages} messages in your inbox. The temperature is {degrees_temp} celsius.");
// # of wasy to print strings is 

Console.Write("Hello");
Console.WriteLine("World");
//WriteLine() will append a new line, while Write() will build over the previous
//another way (printing value or var string)
string template = "Hi We have these flights for you: {0}. Which one do you want";
string data = "A, B, C, D";
string message = string.Format(template, data);
//______________________________________________________________________________
//Store and Retrieve Data
// here are the basics for data types and how to use them
// For numerical datatpes we have:

//for int
Console.WriteLine(25);
//for float
Console.WriteLine(0.25F);
//double is the default
Console.WriteLine(2.625);
//decimal
Console.WriteLine(12.39816m);


// Bool (same as most cases)
Console.WriteLine(true);
Console.WriteLine(false);

// Variable types
/*
- Variable names can include letters, numbers, and underscores but not special characters like `#` or `$`.
- They must start with a letter or an underscore, not a number.
- Variable names are case-sensitive, so `string Value;` and `string value;` are considered different.
- Names must not use C# reserved keywords, such as in the declarations `decimal decimal;` or `string string;`.
*/
// here are some examples of how to use and set up variables:
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;
var message;
//the var keyword is useful for simplifying variable declarations when the type is clear from the initialization. 
//It also aids in more flexible coding when the exact data type isn't initially known, allowing for dynamic development.
// Its importnant to note that if you try to print any of these variable
//you will get an error since in C# you need to initialize the variable
//meaning you cant leave it FULLY empty, so you have to do something like this:

string firstName;
firstName = "Bob";
//or
string firstname = "Bob";

// OJO/NOTE: C# is sequential so you can change the value of a var (as long as its the same type), after using it. for example:
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

//________________________________________________________________________________
//For mathematical functions, if youve used math in code, its not that different. here is a few examples of basic arithmatic:

int sum = 5 + 3; // sum is 8
int difference = 5 - 3; // difference is 2
int product = 5 * 3; // product is 15
int quotient = 5 / 3;   // quotient is 1
double preciseQuotient = 5.0 / 3; // preciseQuotient is approximately 1.66667
int remainder = 5 % 3; // remainder is 2
int result = 3 + 1 * 5 / 2; // end result 5

// now for more complex functions like sqrt, trig, exponentials, etc. you need to import System.Math. here is an example:

import System.Math;
using System;

class Program
{
    static void Main()
    {
        // Calculate the square root of a number
        double number = 16;
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine($"The square root of {number} is {squareRoot}");

        // Raise a number to a power
        double baseNum = 2;
        double exponent = 3;
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is {power}");

        // Find the absolute value
        int negativeNum = -5;
        int absValue = Math.Abs(negativeNum);
        Console.WriteLine($"The absolute value of {negativeNum} is {absValue}");

        // Trigonometric functions: sine, cosine, and tangent
        double angle = Math.PI / 4; // 45 degrees in radians
        double sin = Math.Sin(angle);
        double cos = Math.Cos(angle);
        double tan = Math.Tan(angle);
        Console.WriteLine($"Sine of 45 degrees is {sin}");
        Console.WriteLine($"Cosine of 45 degrees is {cos}");
        Console.WriteLine($"Tangent of 45 degrees is {tan}");

        // Rounding a floating point number
        double floatingPoint = 9.856;
        double rounded = Math.Round(floatingPoint);
        Console.WriteLine($"Rounded value of {floatingPoint} is {rounded}");

        // Get the larger and smaller of two numbers
        double num1 = 3.5;
        double num2 = 2.5;
        double max = Math.Max(num1, num2);
        double min = Math.Min(num1, num2);
        Console.WriteLine($"Maximum of {num1} and {num2} is {max}");
        Console.WriteLine($"Minimum of {num1} and {num2} is {min}");
    }
}





