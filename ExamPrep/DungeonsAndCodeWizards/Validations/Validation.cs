using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Validations
{
    public class Validation
    {
        public bool isAlive(Character character)
        {
            if (character.IsAlive)
            {
                return true;
            }
            return false;
        }
    }
}
