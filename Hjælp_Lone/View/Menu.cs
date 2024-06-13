using System;

namespace Hjælp_Lone.View
{
    public class Menu
    {
        public ConsoleKeyInfo MainMenu()
        {
            Console.WriteLine("Well well well... We meet again!\n" +
                "Before you can move on, you need to choose a character from the list below:\n\n" +
                "1. Wizard\n" +
                "2. Babarian\n" +
                "3. Knight\n" +
                "4. Witch");
            return Console.ReadKey();
        }
    }
}
