using System;

namespace SnakeAndLadder
{
    class SnakeGame
    {
        public int End_Position = 100;
        public int person1=0;
        public int person2=0;
        public void Play()
        {
            
            while (person1 != End_Position|| person2 != End_Position)
            {
                Random random = new Random();
                int position1 = random.Next(1, 7);
                person1 = person1 + position1;
                if (person1 == 100)
                {
                    Console.WriteLine("Player-1 Win");
                    break;
                }
                else if (person1 < 100)
                {
                    Random random2 = new Random();
                    int position2 = random.Next(1, 7);
                    person2 = person2 + position2;
                    if (person2 == 100)
                    {
                        Console.WriteLine("Player-2 Win");
                        break;
                    }
                    else if (person2 > 100)
                    {
                        person2 = person2 - position2;
                    }
                }
                else
                {
                    person1 = person1 - position1;
                }
            }
            
        }
        static void Main(string[] args)
        {
            SnakeGame Start = new SnakeGame();
            Start.Play();

        }

    }
}
