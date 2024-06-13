using Hjælp_Lone.Model;
using Hjælp_Lone.View;
using System;

namespace Hjælp_Lone.Controller
{
    internal class MainController
    {
        public void StartController()
        {
            Menu menu = new Menu();
            WizardController wizardController = new WizardController();
            WizardGUI wizardGUI = new WizardGUI();
            Wizard wizard = new Wizard();
            ConsoleKeyInfo key = menu.MainMenu();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        ConsoleKeyInfo spell = wizardGUI.Wizard();
                        wizardController.SpellCasting(spell);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Babarian babarian = new Babarian();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Knight knight = new Knight();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        Witch witch = new Witch();
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        break;
                    }
            }
        }
    }
}
