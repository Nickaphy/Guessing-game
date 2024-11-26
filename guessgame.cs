using System.Diagnostics;
namespace Program
{
    public class StartGame
    {
        private int difficulty;
        //this is a constructor which is not a method used to initialize an instance of this class
        public StartGame(int difficultychoice)
        {
            difficulty = difficultychoice;
        }

        public void Start()
        {
            Random tilfældig = new Random(); //making our random object
            switch (difficulty)
            {
                case 1: //Easy difficulty game
                int i = 0;
                Console.WriteLine("Guessing game on easy difficulty!\nYou will guess a whole number between 0 and 25");
                int EasyNumber = tilfældig.Next(0, 26); //generating a number between 0-25

                while (i < 26)
                {
                    Console.WriteLine("Guess: ");
                    string easyinput = Console.ReadLine();
                    int EasyGuess;

                    if (int.TryParse(easyinput, out EasyGuess)) //parsing and error handling string to int
                    {
                        i ++; //tries counter +1
                        if (EasyGuess > EasyNumber)
                        {
                            Console.WriteLine("Too high");
                        }else if (EasyGuess < EasyNumber)
                        {
                            Console.WriteLine("Too low");
                        }else if (EasyGuess > 25)
                        {
                            Console.WriteLine("Between 0 - 25...");
                        }else if (EasyGuess == EasyNumber)
                        {
                            Console.WriteLine("U WON!\nWanna play again [Y]es[N]o");
                            string EasyRestart = Console.ReadLine();
                            EasyRestart = EasyRestart.ToUpper();
                            if (EasyRestart == "Y")
                            {
                                Console.WriteLine("I will clear the console for you\nJust restart the program");
                                Thread.Sleep(3000);
                                Console.Clear();
                                Environment.Exit(0);

                            }else if (EasyRestart == "N")
                            {
                                Console.WriteLine("Thank you for playing");
                                Thread.Sleep(3000);
                                Console.Clear();
                                Environment.Exit(0);
                            }else if (EasyRestart != "Y" || EasyRestart != "N")
                            {
                                Console.WriteLine("Y or N wasn't rocket science BYE...");
                                Thread.Sleep(3000);
                                Console.Clear();
                                Environment.Exit(0);
                            }
                        }
                        if (i>25)
                        {
                            Console.WriteLine("U have now spent 25 tries guessing a number between 0 and 25\nI think we might have to stop here");
                            Thread.Sleep(4000);
                            Console.Clear();
                            Environment.Exit(0);
                        }
                    }else
                    {
                        Console.WriteLine("A number...");
                        Thread.Sleep(1000);
                    }
                }

                break;
                case 2:

                break;
                case 3:

                break;
            }
        }
    }
}
