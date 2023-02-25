using System;

namespace Shifting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Elements = 5;
            int[] numbers = new int[Elements] { 1, 2, 3, 4, 5 };
            int shift;
            int temp;

            for (int i = 0; i < Elements; i++)
            {
                Console.Write(numbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("На сколько циклически сдвинуть массив");

            shift = Convert.ToInt32(Console.ReadLine());
            while (shift > 0)
            {
                temp = numbers[Elements-Elements];

                for (int i = 1; i < Elements; i++)
                {
                    numbers[i - 1] = numbers[i];
                }

                numbers[Elements-1] = temp;
                shift--;
            }

            for (int i = 0; i < Elements; i++)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}
