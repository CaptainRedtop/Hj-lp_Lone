using Hjælp_Lone.Interfaces;
using System;

namespace Hjælp_Lone.Model
{
    internal class Knight : IGeneralCharacter, IPhysicalFighting, IDefensive
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
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }
        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
    }
}
