# TwistedFizzBuzz

TwistedFizzBuzz is a C# library that provides a flexible and extensible implementation of the classic FizzBuzz problem. It allows users to generate FizzBuzz sequences for a range of numbers, a non-sequential set of numbers, and even with custom tokens and divisors. It also includes a feature to fetch tokens from an API.

## Library Methods

The library provides the following methods:

- `GenerateFizzBuzzForRange(int start, int end)`: Generates a FizzBuzz sequence for a range of numbers.

- `GenerateFizzBuzzForNumbers(List<int> numbers)`: Generates a FizzBuzz sequence for a non-sequential set of numbers.

- `GenerateAlternativeFizzBuzzForRange(int start, int end, Dictionary<int, string> tokens)`: Generates a FizzBuzz sequence for a range of numbers with custom tokens and divisors.

- `GenerateAlternativeFizzBuzzForNumbers(List<int> numbers, Dictionary<int, string> tokens)`: Generates a FizzBuzz sequence for a non-sequential set of numbers with custom tokens and divisors.

- `GenerateApiFizzBuzzForRange(int start, int end)`: Generates a FizzBuzz sequence for a range of numbers with tokens fetched from an API.

- `GenerateApiFizzBuzzForNumbers(List<int> numbers)`: Generates a FizzBuzz sequence for a non-sequential set of numbers with tokens fetched from an API.

## Console Applications

The library is accompanied by two console applications:

1. **FizzBuzzConsole**: This application uses the TwistedFizzBuzz library to solve the standard FizzBuzz problem. It includes methods to test the library functions with a range of numbers and a non-sequential set of numbers.

2. **CustomFizzBuzzConsole**: This application uses the TwistedFizzBuzz library to generate a FizzBuzz sequence with custom tokens and divisors. It outputs values from -20 to 127, with multiples of 5 printing "Fizz", multiples of 9 printing "Buzz", and multiples of 27 printing "Bar". For multiples where more than one number matches, it prints the appropriate concatenated tokens.

## Getting Started

To use the TwistedFizzBuzz library and console applications, clone the repository and open the solution in Visual Studio. The library can be referenced in other .NET projects, and the console applications can be run directly from Visual Studio.
