using System;
using System.Linq;

namespace Excercise37
{
    class Program
    {
        static void Main(string[] args)
        {

            char continueFlag;
            do
            {
                int[] array = new int[5];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Please enter a number");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int sum;
                sum = array.Sum();
                Console.WriteLine($"The sum of is {array[0]}. {array[1]}, {array[2]}, {array[3]} and {array[4]}{sum}");

                Console.WriteLine("Would you like to contune? (y/n)");
                continueFlag = Console.ReadLine().ToLower()[0];
            } while (continueFlag == 'y');
        }
    }
}
