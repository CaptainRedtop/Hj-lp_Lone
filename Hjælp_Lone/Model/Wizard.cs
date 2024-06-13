using Hjælp_Lone.Interfaces;
using System;

namespace Hjælp_Lone.Model
{
    public class Wizard : IGeneralCharacter, IMagic, ITeleport
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
        public string ThrowMagicMissile()
        {
           return "I'm throwing a magic misile";
        }
        public string ThrowFrostNova()
        {
            return "I'm throwing my frost nova";
        }
        public string Teleport(int x, int y)
        {
            return "I'm teleporting to " + x + " " + y;
        }
    }
}
