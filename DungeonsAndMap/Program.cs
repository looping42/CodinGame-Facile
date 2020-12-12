using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndMap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int w = int.Parse(inputs[0]);
            int h = int.Parse(inputs[1]);
            inputs = Console.ReadLine().Split(' ');
            int startRow = int.Parse(inputs[0]);
            int startCol = int.Parse(inputs[1]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    string mapRow = Console.ReadLine();
                }
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("mapIndex");
        }
    }
}