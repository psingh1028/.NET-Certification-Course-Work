// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool isRainy = false;

bool hasUmbrella = true;


if (isRainy)
{
    Console.WriteLine("Its's raining");
}
Console.ReadKey();

//Nested If statements 

int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if(age > 18)
{
       Console.WriteLine("You are an adult");
}
else if (age >= 13 && age <= 18)
{
    Console.WriteLine("You are a teenager");
}

//switch statements 

int month;
string monthName;
switch (month)
{
    case 1: 
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:


}