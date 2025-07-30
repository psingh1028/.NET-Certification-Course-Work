// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

string question1 = "what is the capital of France?";
string answer1 = "Paris"; 

string question2 = "what is the capital of Spain?";
string answer2 = "Madrid";

string question3 = "what is the capital of Italy?";
string answer3 = "Rome";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Incorrect! The correct answer is {answer1}.");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Incorrect! The correct answer is {answer2}.");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Incorrect! The correct answer is {answer3}.");
}

Console.WriteLine($"Your total score was {score} out of 3.");

if(score == 3)
{
    Console.WriteLine("wow you got a perfect score!, congrats");
}



Console.ReadKey();

