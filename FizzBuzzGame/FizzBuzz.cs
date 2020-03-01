namespace FizzBuzzGame
{
    public class FizzBuzz : IFizzBuzzStrategy
    {
        public string GetValue(int value) => IsValid(value) ? "FizzBuzz" : string.Empty;

        public bool IsValid(int value) => value % 15 == 0;
    }
}