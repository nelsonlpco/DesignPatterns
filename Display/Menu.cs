using System;
using System.Collections.Generic;

namespace Display
{
    public class Menu
    {
        private List<string> _options;
        private int _totalItens = 1;

        public int ExitOption { get { return _totalItens; } }

        public Menu()
        {
            _options = new List<string>();
       }

        public void AddMenuOption(string option)
        {
            _options.Add($@"{option}: {_totalItens}");
            _totalItens++;
        }

        public int ReadeMenuSelectOption()
        {
            var option = 0;

            Console.Clear();
            Console.WriteLine("========== MENU ==========");
            _options.ForEach(option => Console.WriteLine($"{option}"));
            Console.WriteLine($"Exit: {this.ExitOption}");

            try
            {
                option = Int16.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Informe o número da opção desejada.");
                Console.ReadLine();
            }

            return option;
        }
    }
}
