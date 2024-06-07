using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Encapsulation CSE210", "programming with functions");

        MathAssignment mathassignment = new MathAssignment("pHYSICAL APPEARANCE", "tILES AND Tales of the Nobles", "Section 7.3", "Problems 8-19");

        string summary = assignment.GetSummary();
        string homeworklist = mathassignment.GetHomeworkList();

        Console.WriteLine(summary);
        Console.WriteLine(homeworklist);
    }
}