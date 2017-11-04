using BowlingScoreCalculator.Logic;
using System;

namespace BowlingScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Bowling Score Calculator!");
                Console.WriteLine("Please insert your score below");

                var scoreInput = Console.ReadLine();

                var bowlingCalculator = new BowlingCalculator();
                var result = bowlingCalculator.Calculate(scoreInput);

                Console.WriteLine($"Congratulations, your score final is {result}!");
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
