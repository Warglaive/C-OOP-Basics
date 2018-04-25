using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> party;
        private CharacterFactory characterFactory;
        private ItemFactory itemFactory;
        private List<Item> itemPool;
        private int lastSurvivorRounds;

        public DungeonMaster()
        {
            this.party = new List<Character>();
            this.characterFactory = new CharacterFactory();
            this.itemFactory = new ItemFactory();
            this.itemPool = new List<Item>();
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
            var characterName = args[0];
            if (this.party.All(c => c.Name != characterName))
            {
                Error.CharacterNotFound(characterName);
            }
            if (!this.itemPool.Any())
            {
                Error.NoItemsInThePool();
            }
            //bug maybe
            var currentCharacter = (Character)this.party.FirstOrDefault(c => c.Name == characterName);
            var poolLastIndex = this.itemPool.Count - 1;
            currentCharacter.ReceiveItem(this.itemPool[poolLastIndex]);
            //possible bug
            return $"{characterName} picked up {this.itemPool[poolLastIndex].GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var itemName = args[1];

            var character = this.party.FirstOrDefault(n => n.Name == characterName);
            var item = this.itemPool.FirstOrDefault(i => i.GetType().Name == itemName);

            if (character == null)
            {
                Error.CharacterNotFound(characterName);
            }
            character.UseItem(item);
            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giver = this.party.FirstOrDefault(n => n.Name == giverName);
            var receiver = this.party.FirstOrDefault(n => n.Name == receiverName);
            var item = this.itemPool.FirstOrDefault(i => i.GetType().Name == itemName);

            if (giver == null)
            {
                Error.CharacterNotFound(giverName);
            }
            if (receiver == null)
            {
                Error.CharacterNotFound(receiverName);
            }
            if (!this.itemPool.Any())
            {
                Error.NoItemsInThePool();
            }
            if (item == null)
            {
                Error.NoItemWithThatName(itemName);
            }
            giver.UseItemOn(item, receiver);
            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giver = this.party.FirstOrDefault(n => n.Name == giverName);
            var receiver = this.party.FirstOrDefault(n => n.Name == receiverName);
            var item = this.itemPool.FirstOrDefault(i => i.GetType().Name == itemName);

            if (giver == null)
            {
                Error.CharacterNotFound(giverName);
            }
            if (receiver == null)
            {
                Error.CharacterNotFound(receiverName);
            }
            if (!this.itemPool.Any())
            {
                Error.NoItemsInThePool();
            }
            if (item == null)
            {
                Error.NoItemWithThatName(itemName);
            }

            var itemToTrade = giver.Bag.GetItem(itemName);
            receiver.ReceiveItem(itemToTrade);
            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            var sb = new StringBuilder();

            foreach (var character in party
                .OrderByDescending(c => c.IsAlive)
                .ThenByDescending(h => h.Health))
            {
                var status = "Dead";
                if (character.IsAlive)
                {
                    status = "Alive";
                }
                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
            }
            return sb.ToString().Trim();
        }

        public string Attack(string[] args)
        {
            var attackerName = args[0];
            var receiverName = args[1];

            var attacker = this.party.FirstOrDefault(a => a.Name == attackerName);
            var receiver = this.party.FirstOrDefault(a => a.Name == receiverName);

            if (attacker == null)
            {
                Error.CharacterNotFound(attackerName);
            }
            if (receiver == null)
            {
                Error.CharacterNotFound(receiverName);
            }

            if (attacker is IAttackable attackingCharacter)
            {
                attackingCharacter.Attack(receiver);
            }
            else
            {
                Error.CannonAttack(attackerName);
            }
            var result = $"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";
            if (!receiver.IsAlive)
            {
                result += $"{receiver.Name} is dead!";
            }
            return result.Trim();
        }

        public string Heal(string[] args)
        {
            var healerName = args[0];
            var healingReceiverName = args[1];

            var healer = this.party.FirstOrDefault(a => a.Name == healerName);
            var receiver = this.party.FirstOrDefault(a => a.Name == healingReceiverName);

            if (healer == null)
            {
                Error.CharacterNotFound(healerName);
            }
            if (receiver == null)
            {
                Error.CharacterNotFound(healingReceiverName);
            }

            if (healer is IHealable healingCharacter)
            {
                healingCharacter.Heal(receiver);
            }
            else
            {
                Error.CannonHeal(healerName);
            }
            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn()
        {
            var result = new StringBuilder();
            var aliveCharacters = this.party.Where(c => c.IsAlive);
            foreach (var character in aliveCharacters)
            {
                var healthBeforeRest = character.Health;
                character.Rest();
                var currentHealth = character.Health;

                result.AppendLine($"{character.Name} rests ({healthBeforeRest} => {currentHealth})");
            }
            if (!aliveCharacters.Any()
                || aliveCharacters.Count() == 1)
            {
                this.lastSurvivorRounds++;
            }
            return result.ToString().Trim();
        }

        public bool IsGameOver()
        {
            var stillAlive = this.party.Count(c => c.IsAlive) <= 1;
            if (stillAlive && this.lastSurvivorRounds > 1)
            {
                return true;
            }
            return false;
        }
    }
}