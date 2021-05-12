using System;

namespace SnakeAndLadder
{
    class SnakeGame
    {
        int START_POSITION = 0;
        public void Play()
        {
            Console.WriteLine(" Single Player Starting Position: " + START_POSITION);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SnakeGame Start = new SnakeGame();
            Start.Play();

        }

    }
}
