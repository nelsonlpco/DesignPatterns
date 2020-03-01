using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzGame
{
    public class Game
    {
        private Dictionary<Func<int, bool>, Func<int, string>> _rules;
        public Game()
        {
            _rules = new Dictionary<Func<int, bool>, Func<int, string>>();
            var fizz = new Fizz();
            var buzz = new Buzz();
            var fizzBuzz = new FizzBuzz();

            _rules.Add(fizzBuzz.IsValid, fizzBuzz.GetValue);
            _rules.Add(buzz.IsValid, buzz.GetValue);
            _rules.Add(fizz.IsValid, fizz.GetValue);
        }

        private string FindResponse(int value) => _rules.FirstOrDefault(r => r.Key.Invoke(value)).Value?.Invoke(value) ?? string.Empty;

        public void PlayByTo(int total)
        {
            for(var index = 1; index <= total; index++)
            {
                var result = FindResponse(index);
                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine(result);
                }
            }
            Console.ReadLine();
        }
    }
}
