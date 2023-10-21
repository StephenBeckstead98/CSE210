using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> sblist = new List<int>(); 

        int sbnumbers = -1; 

        while (sbnumbers != 0) {
        Console.WriteLine("Enter Number");
        string sbrandom = Console.ReadLine();
        
        sbnumbers = int.Parse(sbrandom); 

        sblist.Add(sbnumbers); 


        }

    int sbsum = 0; 
     foreach (int i in sblist) {
        sbsum += i; 
     }
     Console.WriteLine($"The sum is: {sbsum}");

     int sbaverage = sbsum / sblist.Count;
     Console.WriteLine($"The average is {sbaverage}");

     int sblargest = 0; 

     foreach (int sbnumber in sblist) {
        if(sbnumber > sblargest) {
            sblargest = sbnumber; 
        }

    }
    Console.WriteLine($"The largest number is {sblargest}");

    }
}