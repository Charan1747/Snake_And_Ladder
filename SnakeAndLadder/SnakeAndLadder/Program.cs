using System;

namespace SnakeAndLadder
{
    class SnakeAndLadder
    {
        int START_POSITION = 0;
        public void PlayGame()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Player Position : " + die);
            Console.WriteLine("Single Player Start Position:  " + START_POSITION);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder();
            StartPlay.PlayGame();
        }
    }
}
