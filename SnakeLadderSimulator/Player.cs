using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{
    internal class Player
    {
        const int LADDER = 1;
        const int SNAKE = 2;
        const int WINNING_POINT = 100;
<<<<<<< HEAD
        public void gamePlay()
=======
        public int gamePlay(int player)
>>>>>>> UC-7
        {
            int tempPosition, diceCount = 0, position = 0;
            while (position < WINNING_POINT)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
<<<<<<< HEAD
                int rolldie = random.Next(1, 7);
=======
                int rollDie = random.Next(1, 7);
                int againRollDie = random.Next(1, 7);
>>>>>>> UC-7
                diceCount++;
                switch (option)
                {
                    case LADDER:
<<<<<<< HEAD
                        tempPosition = position + rolldie;
=======
                        tempPosition = position + rollDie;
>>>>>>> UC-7
                        if (tempPosition > 100)
                        {
                            position += 0;
                        }
                        else
                        {
<<<<<<< HEAD
                            position = tempPosition;
                        }
                        break;
                    case SNAKE:
                        tempPosition = position - rolldie;
=======
                            tempPosition += againRollDie;
                            diceCount++;
                            if (tempPosition > 100)
                            {
                                position += 0;
                            }
                            else
                            {
                                position = tempPosition;
                            }
                        }
                        break;
                    case SNAKE:
                        tempPosition = position - rollDie;
>>>>>>> UC-7
                        if (tempPosition <= 0)
                        {
                            position = 0;
                        }
                        else
                        {
                            position = tempPosition;
                        }
                        break;
                    default:
                        position += 0;
                        break;
                }
<<<<<<< HEAD
                Console.WriteLine("Player 1 position is " + position);
            }
            Console.WriteLine("The " + diceCount + " times the dice was played to win the game.");
=======
                Console.WriteLine("Player "+player+" position is " + position);
            }
            Console.WriteLine("The " + diceCount + " times the dice was played to win the game.");
            return diceCount;
>>>>>>> UC-7
        }
    }
}
