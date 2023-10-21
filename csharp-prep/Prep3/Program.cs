using System;

class Program
{
    static void Main(string[] args)
    {

    Random randomGenerator = new Random();
    int sbnumber = randomGenerator.Next(1, 14);

    int sbguess = 0; 

    while (sbguess != sbnumber) {
        Console.WriteLine("Enter Guess"); 
        string sbrandom = Console.ReadLine();
        sbguess = int.Parse(sbrandom); 

        if (sbguess == sbnumber) 
        {
            Console.WriteLine("perfect");
        }
        if (sbguess > sbnumber)
        {
            Console.WriteLine("Lower");
        }
        if (sbguess < sbnumber) 
        {
            Console.WriteLine("Higher");
        }
    }


    }
}