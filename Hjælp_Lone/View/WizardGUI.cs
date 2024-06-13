using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Lone.View
{
    internal class WizardGUI
    {
        public ConsoleKeyInfo Wizard()
        {
            Console.Clear();
            Console.WriteLine("You have chosen the wise wizard!\n" +
                "The wizard is a powerfull character, who uses magic to defeat his foes!\n" +
                "You have the following abilities:\n\n" +
                "1. Fight\n" +
                "2. Heal\n" +
                "3. Throw Magic Missiles\n" +
                "4. Throw Frostnova\n" +
                "5. Teleport\n" +
                "6. Give up");

            return Console.ReadKey();
        }

        public void WizardSpellCasting(string spell)
        {
            Console.Clear();
            Console.WriteLine(spell);
            Console.Read();
        }
    }
}
