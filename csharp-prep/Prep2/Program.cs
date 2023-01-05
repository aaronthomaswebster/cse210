using System;

class Program
{
    static void Main(string[] args)
    {
        float passingGrade = 70;
        String gradeModifier = "";
        String letter = "";
        float grade;
        Console.Write("Enter your grade percentage: ");
        String inputGrade = Console.ReadLine();

        grade = float.Parse(inputGrade);
        if(grade >= 90)
        {
            letter = "A";
        }
        else if(grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if(grade % 10 >= 7 && letter != "A" && letter != "F")
        {
            gradeModifier = "+";
        }
        else if(grade % 10 <= 3 && grade != 100 && letter != "F")
        {
            gradeModifier = "-";
        }


        Console.WriteLine($"Letter grade: {letter}{gradeModifier}");

        if(grade >= passingGrade)
        {
            Console.WriteLine("Congratulations, you have passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you have not passed the class. Better luck next time.");
        }
    }
}