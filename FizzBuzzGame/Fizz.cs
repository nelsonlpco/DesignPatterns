namespace FizzBuzzGame
{
    public class Fizz : IFizzBuzzStrategy
    {
        public string GetValue(int value) => IsValid(value) ? "Fizz" : string.Empty;

        public bool IsValid(int value) => value % 5 == 0;
    }
}