using System;
using System.Collections.Generic;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<ICharacter> party;
        private CharacterFactory characterFactory;
        private ItemFactory itemFactory;
        private List<IItem> itemPool;

        public DungeonMaster()
        {
            this.party = new List<ICharacter>();
            this.characterFactory = new CharacterFactory();
            this.itemFactory = new ItemFactory();
            this.itemPool = new List<IItem>();
        }
        public string JoinParty(string[] args)
        {
            if (Enum.TryParse<Faction>(args[0], out var faction))
            {
                var characterClass = args[1];
                if (characterClass != "Warrior" && characterClass != "Cleric")
                {
                    Error.InvalidCharacterType(args[1]);
                }
                var name = args[2];
                var currentCharacter = characterFactory
                    .CreateCharacter(faction, characterClass, name);
                this.party.Add(currentCharacter);
            }
            else
            {
                Error.InvalidFaction(args[0]);
            }
            return $"{args[2]} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];
            var currentItem = this.itemFactory.CreateItem(itemName);
            this.itemPool.Add(currentItem);
            return $"{itemName} added to pool.";
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