using System;

class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter = 'X';

    public Question()
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null.
        //Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        this.questionText = null;
        this.optionA = null;
        this.optionB = null;    
        this.optionC = null;
        this.optionD = null;
        this.correctAnswerLetter = defaultCorrectAnswerLetter;
    }

    public Question(string questionText)
    {
        //TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null.
        //Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        this.questionText = questionText;
        this.optionA = null;
        this.optionB = null;
        this.optionC = null;
        this.optionD = null;
        this.correctAnswerLetter = defaultCorrectAnswerLetter;
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText.
        //Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;
        if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
        {
            this.correctAnswerLetter = correctAnswerLetter;
        }
        else
        {
            Console.WriteLine("Invalid correct answer letter. It should be either 'A', 'B', 'C' or 'D'.");
        }
    }

    public bool AreOptionsValid()
    {
        //TO DO: Return true, if at least two options are not null
    }
}

class Program
{
    static void Main()
    {
        //TO DO: Create an object of Question class and pass no arguments to the constructor
        //TO DO: Create an object of Question class and pass value for questionText only to the constructor.
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
    }
}
