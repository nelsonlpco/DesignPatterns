using System;

namespace Display
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategySample = new StrategySample();
            var menu = new Menu();
            menu.AddMenuOption(strategySample.GetMenuOption());
            

            var option = 0;
            while(option != menu.ExitOption)
            {
                option = menu.ReadeMenuSelectOption();
                if (option == 1)
                {
                    strategySample.Run();
                }
            }
        }
    }
}
