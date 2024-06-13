using System;
using Hjælp_Lone.Model;
using Hjælp_Lone.View;

namespace Hjælp_Lone.Controller
{
    internal class WizardController
    {
        bool spellCasting = true;
        Wizard wizard = new Wizard();
        WizardGUI wizardGui = new WizardGUI();
        public void SpellCasting(ConsoleKeyInfo spell)
        {
            while (spellCasting == true)
            {
                switch (spell.Key)
                {
                    case ConsoleKey.D1:
                        {
                            wizardGui.WizardSpellCasting(wizard.Fight());
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            wizardGui.WizardSpellCasting(wizard.Heal());
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            wizardGui.WizardSpellCasting(wizard.ThrowMagicMissile());
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            wizardGui.WizardSpellCasting(wizard.ThrowFrostNova());
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            wizardGui.WizardSpellCasting(wizard.Teleport(15, 15));
                            break;
                        }
                }
            }
        }
    }
}
