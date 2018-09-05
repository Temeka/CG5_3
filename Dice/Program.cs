using System;

namespace Dice
{
    class Program
    {

        static void Main(string[] args)
        {
            //declaring both 'player' value
            int ParOne = 0;
            int Computer = 0;

            do 
            {
                //generating a random # for Participant 
                ParOne += RollDice();

                //informing particpant of the random roll
                Console.WriteLine("Your score is: " + ParOne);

                //generating a randm # for Computer
                Computer += RollDice(); 

                //also informing of the computer's roll value
                Console.WriteLine("Computer's score is: " + Computer);

                //initializing the value of the loop 
            } while (ParOne <= 20 && Computer <= 20); 

            //if the participant roll is greater than or equal to '20'. The par wins
            if (ParOne >= 20) 
            {
                Console.WriteLine("Congrats, you won!");
            }
            //if the Computer's & Par's roll is greater than or equal to '20' (participant win per they're 1st)
            else if (Computer >= 20 && ParOne >= 20) 
            {
                Console.WriteLine("Congrats, you won!");
            }

            //if the Computer roll is greater than or equal to '20' then the computer wins
            else if (Computer >= 20 && ParOne < 20)
            {
                Console.WriteLine("Computer wins!");
            }
            

            Console.ReadLine();
        }

        /// <summary>
        /// Using a 6 sided die to prompt return of the interger
        /// </summary>
        /// <returns>
        /// A random result from die roll.
        /// </returns>
        private static int RollDice()
        {
            //randomizing
            Random rnd = new Random();

            //declaring int and prompting to return a random # up to 6
            int rollScore = rnd.Next(1, 6);

            //asking for a # return from the roll
            return rollScore;
        }

        
    }




    }

