//// See https://aka.ms/new-console-template for more information
//using System.Security.Cryptography;

//Console.WriteLine("Hello, World!");

//string choice = Console.ReadLine().Trim().ToLower(); 

//Random random = new Random();

//int randomNumber = random.Next(1, 26);

//string inputString = Console.ReadLine();
////int num1 = int.Parse(inputString);
//int num1;

//bool isNumber = int.TryParse(inputString, out num1);

//if (isNumber)

//{
//    Console.WriteLine("you have entered a valid number");

//    if (num1 == randomNumber)
//    {
//        Console.WriteLine("you have entered the correct number");
//    }
//    else
//    {
//        Console.WriteLine("you did not enter the correct number");
//    }
//}
//else
//{
//    Console.WriteLine("you did not enter a valid number");
//}

//Console.ReadKey();

//// creating an instance of the Randome Class 

int num1;
int num2;
int result;

Console.WriteLine("Enter the first number:");

bool isValidNum1 = int.TryParse(Console.ReadLine(), out num1);

if (isValidNum1)
{
    Console.WriteLine("Enter the second number:");
    bool isValidNum2 = int.TryParse(Console.ReadLine(), out num2);

    if (isValidNum2)
    {
        Console.WriteLine("Choose an operation: +, -, *, /");
        string choice = Console.ReadLine().Trim();
        switch (choice)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                break;

            default:
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                break;
        }
    }
    else Console.WriteLine("Invalid input for second number.");
}
else Console.WriteLine("Invalid input for first number.");



Console.ReadKey();




