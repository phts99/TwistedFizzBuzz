using TwistedFizzBuzz;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            TestRangeInput(fizzBuzz);

            TestSequencialInput(fizzBuzz);

            TestApiRangeInput(fizzBuzz);

            TestApiSequencialInput(fizzBuzz);
        }

        private static async void TestRangeInput(FizzBuzz fizzBuzz)
        {
            var result = fizzBuzz.GenerateFizzBuzzForRange(1, 100);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var result2 = fizzBuzz.GenerateFizzBuzzForRange(-2, -37);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }

        private static async void TestSequencialInput(FizzBuzz fizzBuzz)
        {
            var result3 = fizzBuzz.GenerateFizzBuzzForNumbers(new List<int> { -5, 6, 300, 12, 15 });
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
        }

        private static async void TestApiRangeInput(FizzBuzz fizzBuzz)
        {
            var apiResult = await fizzBuzz.GenerateApiFizzBuzzForRange(-2, -37);
            foreach (var item in apiResult)
            {
                Console.WriteLine(item);
            }
        }

        private static async void TestApiSequencialInput(FizzBuzz fizzBuzz)
        {
            var apiResult = await fizzBuzz.GenerateApiFizzBuzzForNumbers(new List<int> { -5, 6, 300, 12, 15 });
            foreach (var item in apiResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
