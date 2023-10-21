using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 
        
        string sbname = PromptUserName();
        int sbnum = PromptUserNumber(); 
        int sqrnum = SquareNumber(sbnum); 

        DisplayResult(sbname, sqrnum); 

    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program"); 
    }

        
    static string PromptUserName() {
        Console.WriteLine("Please Enter Your Name");
        string sbname = Console.ReadLine(); 
        return sbname; 
    }

    static int PromptUserNumber() {
        Console.WriteLine("Please Enter Your Favorite Number"); 
        string sbfavnum = Console.ReadLine(); 
        int sbnum = int.Parse(sbfavnum); 
        return sbnum; 
    }
        
    static int SquareNumber(int sbnum) {
        int sqrnum =  sbnum * sbnum; 
        return sqrnum; 
    }

    static void DisplayResult(string sbname,int sqrnum) {
        Console.WriteLine($"{sbname}, the square of your number is {sqrnum}");

    }

    }
    