using TwistedFizzBuzz;

namespace CustomFizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomTokenFizzBuzzForRange();

            TestCustomTokenFizzBuzzForNumbers();
        }

        private static void TestCustomTokenFizzBuzzForRange()
        {
            var fizzBuzz = new FizzBuzz();
            var tokens = new Dictionary<int, string>
            {
                { 5, "Fizz" },
                { 9, "Buzz" },
                { 27, "Bar" }
            };

            var rangeResult = fizzBuzz.GenerateCustomTokenFizzBuzzForRange(-20, 127, tokens);
            Console.WriteLine("Custom Token FizzBuzz for range -20 to 127:");
            foreach (var item in rangeResult)
            {
                Console.WriteLine(item);
            }
        }

        private static void TestCustomTokenFizzBuzzForNumbers()
        {
            var fizzBuzz = new FizzBuzz();
            var tokens = new Dictionary<int, string>
            {
                { 5, "Fizz" },
                { 9, "Buzz" },
                { 27, "Bar" }
            };

            var numbersResult = fizzBuzz.GenerateCustomTokenFizzBuzzForNumbers(new List<int> { -5, 6, 300, 12, 15 }, tokens);
            Console.WriteLine("Custom Token FizzBuzz for numbers -5, 6, 300, 12, 15:");
            foreach (var item in numbersResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
