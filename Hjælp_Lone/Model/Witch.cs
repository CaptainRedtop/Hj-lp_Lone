using Hjælp_Lone.Interfaces;
using System;

namespace Hjælp_Lone.Model
{
    internal class Witch : IGeneralCharacter, IDefensive, ITeleport
    {
        public string Fight()
        {
            return "I'm fighting";
        }
        public string Die()
        {
            return "I'm dying";
        }
        public string Heal()
        {
            return "I'm healing";
        }
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public string Teleport(int x, int y)
        {
            return "I'm teleporting to " + x + " " + y;
        }
    }
}
