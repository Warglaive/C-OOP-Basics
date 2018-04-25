using System;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Classes;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(Faction faction
            , string characterClass, string name)
        {
            Character currentChar = null;
            switch (characterClass)
            {
                case "Warrior":
                    currentChar = new Warrior(name, faction);
                    break;
                case "Cleric":
                    currentChar = new Cleric(name, faction);
                    break;
                default:
                    Error.InvalidCharacterType(characterClass);
                    break;
            }
            return currentChar;
        }
    }
}