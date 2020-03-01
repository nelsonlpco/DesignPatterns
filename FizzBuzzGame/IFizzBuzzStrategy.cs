namespace FizzBuzzGame
{
    public interface IFizzBuzzStrategy
    {
        bool IsValid(int value);

        string GetValue(int value);
    }
}