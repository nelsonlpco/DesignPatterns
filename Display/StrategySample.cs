using FizzBuzzGame;

namespace Display
{
    public class StrategySample : ISample
    {
        private Game _game;

        public StrategySample()
        {
            _game = new Game();
        }

        public string GetMenuOption() => "Strategy Sample";

        public void Run() => _game.PlayByTo(20);
    }
}