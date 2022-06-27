//number ananyzer and decision maker
using System;
using System.Linq;
using System.Text;


namespace numberAnalyzer;



class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name.: ");
        var userName = Console.ReadLine();
        Console.WriteLine("Hello there," + userName);




        var i = 0;
        Console.WriteLine("Enter a number between 1 and 100.: ");
        
        string numPick = Console.ReadLine();

        if (i % 2 == 0)
        {
            Console.WriteLine("its an enen number");
        }
        else
        {
            Console.WriteLine("its an even number");

            for (i = 1; i <= 100; i++)//show numbers 1-100
                if (i % 2 == 0) ;//even numbers



            if (i <= 60) ; //A.
            Console.WriteLine("Odd and less than 60." + userName);

            for (i = 2; i <= 24; i++) ;  //B.   
            Console.WriteLine("Even and less than 25." + userName);

            //if (i >= 26; i => 60;  //C.          
            //Console.WriteLine("Even and between 26 and 60 inclusive." + userName);

            if (i > 60) ;   //D.
            Console.WriteLine("Even and greater than 60." + userName);

            if (i > 60) ;   //E.
            Console.WriteLine("Odd and greater than 60." + userName);


        if (i % 2 != 0) ;//Odd numbers

            //*******exit program thread*****************
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        }

    }

}
        
        

    









