using System;
using System.Collections.Generic;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Classes;
using DungeonsAndCodeWizards.Factories;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> party;
        private CharacterFactory characterFactory;

        public DungeonMaster()
        {
            this.party = new List<Character>();
        }
        public string JoinParty(string[] args)
        {
            Faction faction;
            Enum.TryParse<Faction>(args[0], out faction);
            var characterClass = args[1];
            var name = args[2];

            var currentCharacter = characterFactory
                .CreateCharacter(faction, characterClass, name);
            //to do
        }

        public string AddItemToPool(string[] args)
        {
            throw new NotImplementedException();
        }

        public string PickUpItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string UseItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string UseItemOn(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GiveCharacterItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GetStats()
        {
            throw new NotImplementedException();
        }

        public string Attack(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Heal(string[] args)
        {
            throw new NotImplementedException();
        }

        public string EndTurn(string[] args)
        {
            throw new NotImplementedException();
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }
    }
}