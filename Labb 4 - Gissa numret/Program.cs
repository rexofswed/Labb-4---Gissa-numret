namespace Labb_4___Gissa_numret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rasmus Kuronen BUV-26, Labb 4 - Gissa numret

            bool PA = true;
            int AmountGuess;
            int rekord = 0;
            String answer;
            while (PA)
            {
                Console.WriteLine();
                Console.WriteLine("You have to guess a number between 1 and 100, you have 10 attempts, go ahead...");
                int guess = 0;
                answer = "";
                AmountGuess = 0;
                Random Number = new Random();
                int Num = Number.Next(1, 101);

                if (rekord > 0) //gives you the previous records
                {
                    Console.WriteLine();
                    Console.WriteLine("Current record " + rekord + ".");
                }

                do
                {
                    if (AmountGuess == 10) // Change the 10 if you want more attempts.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unfortunately, you have no more attempts left.");
                        Console.WriteLine("the random number was: " + Num);
                        break;
                    }
                    AmountGuess++;
                    guess = int.Parse(Console.ReadLine());
                    if (guess > 100 || guess < 1) // Make sure you guess a number between 1 and 100
                                                  // also remove the guess from the record.
                    {
                        Console.WriteLine("You must enter a number between 1 and 100!");
                        AmountGuess --;
                    } 
                    if (guess > Num) //says whether you guessed too high or too low.
                    {
                        Console.WriteLine("Your number is too bigg. Guess a smaller number.");
                    }
                    else
                    {
                        Console.WriteLine("Your number is too small. Guess a bigger number.");
                    }
                    if (Math.Abs(guess - Num) <= 5) //says if you are close, change the 'five' if you want to increase or decrease the sensitivity.
                    {
                        Console.WriteLine("you're close, it is getting warmer.");
                    }
                    if (guess == Num) // if you guessed correctly and show how many attempts.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Congratulations, you guessed correctly!");
                        Console.WriteLine("It took you " + AmountGuess + " attempts.");
                    }
                }
                while (guess != Num); // lets you know if you set a new record.
                if (AmountGuess < rekord || rekord == 0 && AmountGuess < 10) //If you change "AmountGuess" on line 29,
                                                                             //you need to change the ten on these line and line on 69.
                {
                    rekord = AmountGuess;
                    Console.WriteLine("It is a new record.");
                }
                else if(rekord != 1 && AmountGuess < 10)
                {
                    Console.WriteLine("Try to beat" + rekord + ".");
                }

                do // asks if you want to play again and handles invalid input.
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? (Y/N)");
                    answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        PA = true;
                    }
                    else if (answer == "N")
                    {
                        PA = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N.");
                    }

                } while (answer != "Y" && answer != "N");

                Console.WriteLine("Thank you for playing. See you next time.");
                Console.ReadKey();
            }
        }
    }
}
