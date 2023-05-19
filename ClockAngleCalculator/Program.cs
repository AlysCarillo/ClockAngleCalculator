using ClockAngleCalculator.Clocks;

namespace ClockAngleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Clock Angle Calculator!\n");

            Console.Write("Please enter hours (12-hours format): ");
            var hrs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter minutes: ");
            var min = Convert.ToInt32(Console.ReadLine());

            ICLock clock = new Clock(hrs, min);

            Console.WriteLine($"\nThe lesser angle in degrees between hours arrow and minutes arrow is {clock.CalculateAngle()}. \n");
        }
    }
}