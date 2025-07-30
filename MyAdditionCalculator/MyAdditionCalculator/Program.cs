// See https://aka.ms/new-console-template for more information
// Prints out whatever is inside the brackets
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
// Takes the user input and stores it in a variable
// Variable with the name "userInput" of data type string 
Console.WriteLine("Please enter a whole number:");
string userInput = Console.ReadLine();

double number = double.Parse(userInput);

Console.WriteLine("Please enter another whole number:");
userInput = Console.ReadLine();

double number2 = double.Parse(userInput);

double sum = number + number2;

// Fixed syntax error by adding the missing '+' operator between variables
Console.WriteLine("The sum of " + number + " + " + number2 + " is " + sum);
Console.WriteLine($"The sum of {number} + {number2} is {sum}");
Console.WriteLine("You Entered " + userInput);
// This is to make the console stay open until a key is pressed
Console.ReadKey();

//implicit conversion

int myInt = 10;
double MyDouble = myInt;

//explicit conversion

long myLong = 10000000000;
int myInt2 = (int)myLong;


//Conversion Helpers Parse and Convert. 
string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine($"mybool is {myBool}");
Console.ReadLine();


//implicitly typed variables
var myFavCar = "BMW";
var myFavNumber = 42;
var myFavDecimal = 14.5;

//string formating
Console.WriteLine("the three test are {0} {1} {2}", myFavCar, myFavNumber, myFavDecimal);
Console.ReadKey();