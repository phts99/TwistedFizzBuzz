using Newtonsoft.Json;

namespace TwistedFizzBuzz
{
    public class FizzBuzz
    {
        // Classic FizzBuzz Range Input
        public List<string> GenerateFizzBuzzForRange(int start, int end)
        {
            return GenerateAlternativeFizzBuzzForRange(start, end, new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });
        }

        // Classic FizzBuzz Sequential Input
        public List<string> GenerateFizzBuzzForNumbers(List<int> numbers)
        {
            return GenerateAlternativeFizzBuzzForNumbers(numbers, new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });
        }

        // Custom Token FizzBuzz Range Input
        public List<string> GenerateCustomTokenFizzBuzzForRange(int start, int end, Dictionary<int, string> tokens)
        {
            return GenerateAlternativeFizzBuzzForRange(start, end, tokens);
        }

        // Custom Token FizzBuzz Sequential Input
        public List<string> GenerateCustomTokenFizzBuzzForNumbers(List<int> numbers, Dictionary<int, string> tokens)
        {
            return GenerateAlternativeFizzBuzzForNumbers(numbers, tokens);
        }

        // Api Token FizzBuzz Range Input
        public async Task<List<string>> GenerateApiFizzBuzzForRange(int start, int end)
        {
            var tokens = await FetchTokensFromApi();
            return GenerateAlternativeFizzBuzzForRange(start, end, tokens);
        }

        // Api Token FizzBuzz Sequential Input
        public async Task<List<string>> GenerateApiFizzBuzzForNumbers(List<int> numbers)
        {
            var tokens = await FetchTokensFromApi();
            return GenerateAlternativeFizzBuzzForNumbers(numbers, tokens);
        }

        private List<string> GenerateAlternativeFizzBuzzForRange(int start, int end, Dictionary<int, string> tokens)
        {
            List<int> numbers;
            if (start <= end)
            {
                numbers = Enumerable.Range(start, end - start + 1).ToList();
            }
            else
            {
                numbers = Enumerable.Range(end, start - end + 1).Reverse().ToList();
            }
            return GenerateAlternativeFizzBuzzForNumbers(numbers, tokens);
        }

        private List<string> GenerateAlternativeFizzBuzzForNumbers(List<int> numbers, Dictionary<int, string> tokens)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                var output = "";
                foreach (var token in tokens)
                {
                    if (number % token.Key == 0)
                        output += token.Value;
                }
                result.Add(string.IsNullOrEmpty(output) ? number.ToString() : output);
            }
            return result;
        }

        private async Task<Dictionary<int, string>> FetchTokensFromApi()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://rich-red-cocoon-veil.cyclic.app/random");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var token = JsonConvert.DeserializeObject<Token>(content);

            return new Dictionary<int, string> { { token.Multiple, token.Word } };
        }
    }
}
