//number ananyzer and decision maker
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;


namespace numberAnalyzer;

//bool should continue

class program 
{
    static void Main(string[] args)
    {
        int i;
      
        int oddNum;
        int evenNum;
        string y = "yes";

        Console.WriteLine("Enter your name.: ");
        string userName = Console.ReadLine();
      
        Console.WriteLine(" \n Hello " + userName + ", Please Enter a number. :");

        bool yes = true;


        i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.Write("Entered Number is an Even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Entered Number is an Odd Number");
            Console.Read();
        }
        if (i % 2 != 0 && i <60)//a.1 point odd less than 60
        {
            Console.WriteLine( "Odd and less than 60" );
        }
        if (i % 2 == 0 && i >= 2 && i < 24)//b.1 point even and less than 25, 2-24 inc
        {  
            Console.WriteLine("Even and less than 25."); 
        }
        if (i % 2 == 0 && i >= 26 && i <= 60)//c.1 point even between 26 and 60 inclusive.
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        if (i % 2 == 0 && i > 60) 
        {
            Console.WriteLine("Even and greater than 60.");//d.even and greater than 60.
        }
        if (i % 2 != 0 && i > 60) 
        {
            Console.WriteLine("Odd and greater than 60.");//e.Odd and greater than 60.
        }

    }
}




