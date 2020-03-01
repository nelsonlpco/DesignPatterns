namespace FizzBuzzGame
{
    public class Buzz : IFizzBuzzStrategy
    {
        public string GetValue(int value) => IsValid(value) ? "Buzz" : string.Empty;

        public bool IsValid(int value) => value % 3 == 0;
    }
}