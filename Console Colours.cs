using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            string[] str = new string[]
            {
             " ________                     __      ",
             "/        |                   /  |     ",
             "########/______    _______  _## |_    ",
             "   ## | /      \\  /       |/ ##   |  ",
             "   ## |/######  |/#######/ ######/    ",
             "   ## |##    ## |##      \\   ## | __ ",
             "   ## |########/  ######  |  ## |/  | ",
             "   ## |##       |/     ##/   ##  ##/  ",
             "   ##/  #######/ #######/     ####/   "
            };
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (i >= 4 && i < 7 && j > 3 && j < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(str[i][j]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();          
            var index = 3;
            foreach (var item in str)
            {
                for (int i = 0; i < item.Length; i++)
                {

                    Console.Write(item[i]);

                    Console.ForegroundColor = (ConsoleColor)index;
                    index++;
                    if (index == 15)
                        index = 3;
                    if (i == item.Length - 1)
                    {
                        Console.Write("\n");
                        continue;
                    }                   
                }
            }
        }
    }
}