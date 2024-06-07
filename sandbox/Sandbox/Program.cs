using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Person man = new Person( "Lehi", "Daniel");
        //man.SetAuthor("Lehi");
        //man.SetTitle("The Great Dragon Ball");
    
        Console.WriteLine(man.GetInformalSignature());    
    
    }
}
