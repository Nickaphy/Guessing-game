using System;
using System.Threading;

namespace Program //namespace for multifile
{

    class Start //main class
    {

        static void Main(string[] args) //main method
        {
            welcome();
        }

        static int welcome() //welcome method
        {
            Console.WriteLine("Welcome to the Guessing Game!\nChoose a diffiulty level: \n[1] Easy\n[2] Medium\n[3] Hard");
            string input = Console.ReadLine(); //reading user input
            int difficultychoice; //declaring an empty int
            if (int.TryParse(input, out difficultychoice)) //try to parse the input to an int and output as difficultychoice
            {
                switch (difficultychoice) //switch statements for the difficulty choice
                {
                    case 1: Console.WriteLine("Easy difficulty!");
                    return difficultychoice;
                    case 2: Console.WriteLine("Medium difficulty!");
                    return difficultychoice;
                    case 3: Console.WriteLine("Hard difficulty!");
                    return difficultychoice;
                    default: Console.WriteLine("Enter a valid difficulty\n");
                    Thread.Sleep(2000);
                    return welcome(); //if not a valid number return to welcome method
                }
            }else
            {
                Thread.Sleep(2000);
                return welcome();
            }
        }
    }
}
