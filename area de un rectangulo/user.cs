namespace Geometry
{
    public static class user
    {
        public static double GetUser(string message)
        {
            Console.WriteLine(message);
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            return input;
        }
    }
}
