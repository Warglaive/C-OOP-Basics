using System;
using System.Reflection;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public ICharacter CreateCharacter(Faction faction, string characterClass, string name)
        {
            var type = Assembly.GetCallingAssembly().GetType(characterClass);

            var instance = (ICharacter)Activator
                .CreateInstance(type, faction, name);

            return instance;
        }
    }
}