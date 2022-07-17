const int LADDER = 1;
const int SNAKE = 2;
Console.WriteLine("Welcome in Snake & Ladder Simulator.");
int position = 0;
Random random = new Random();
int option = random.Next(0,3);
int rolldie = random.Next(1,7);
Console.WriteLine("Player 1 position is " + position);
switch(option)
{
    case LADDER:
        position += rolldie;
        break;
    case SNAKE:
        position -= rolldie;
        break;
    default:
        position += 0;
        break;
}    
Console.WriteLine("Player 1 position is " +position);