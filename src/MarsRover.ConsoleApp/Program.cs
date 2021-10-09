using System;
using System.Drawing;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Grid values; 5 5");
            var grid = Console.ReadLine().Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            Scene.Init(Convert.ToInt32(grid[0]), Convert.ToInt32(grid[1]));

            Console.WriteLine("actor count");
            var actorCount = Convert.ToInt32(Console.ReadLine());

            IActor[] actors = new Actor[actorCount];
            for (int i = 0; i < actorCount; i++)
            {
                var location = Console.ReadLine().Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                var input = Console.ReadLine().ToCharArray();
                actors[i] = new Actor(new Point(int.Parse(location[0]), int.Parse(location[1])), char.Parse(location[2]), input);
            }
            foreach (var item in actors)
            {
                Console.WriteLine(item.Calculate());
            }
        }
    }
}
