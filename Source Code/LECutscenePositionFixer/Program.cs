using System;

namespace LECutscenePositionFixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str =
            {
                "Enter your ",
                "Your new ",
                "position: ",
                "Помилка ",
                "\n\nСкорiше за все, Ви помилилися пiд час написання позицiї. Переконайтеся, що використовуєте коми, а не крапки + не пишiть туди якихось iнших символiв, окрiм чисел та ком.\n",
                "\nCopied to clipboard!\n"
            };
            double your_position, fixed_position;
            try
            {
                Console.WriteLine(str[0] + str[2]);
                your_position = Convert.ToDouble(Console.ReadLine());
                fixed_position = (-180 - (180 - your_position));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(str[1] + str[2] + fixed_position);
            }
            catch (FormatException y)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(str[3] + y + str[4]);
            }
            Console.ReadKey();
        }
    }
}
