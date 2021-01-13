using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Serpent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Window size
            Console.SetBufferSize(150, 95);

            // Drawing a fram
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            // Drawing points
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    /*
                     * if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                    */
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
