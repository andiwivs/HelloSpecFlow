﻿using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            _player = new PlayerCharacter();
        }

        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }
        
        [Then(@"My health should be (.*)")]
        public void ThenMyHealthShouldBe(int expectedHealth)
        {
            Assert.AreEqual(expectedHealth, _player.Health);
        }

        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.IsTrue(_player.IsDead);
        }

        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int damageResistance)
        {
            _player.DamageResistance = damageResistance;
        }

        [Given(@"I'm an Elf")]
        public void GivenImAnElf()
        {
            _player.Race = "Elf";
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            dynamic attributes = table.CreateDynamicInstance();

            _player.Race = attributes.Race;
            _player.DamageResistance = attributes.DamageResistance;
        }

        [Given(@"My character class is set to (.*)")]
        public void GivenMyCharacterClassIsSet(CharacterClass characterClass)
        {
            _player.CharacterClass = characterClass;
        }

        [When(@"Cast a healing spell")]
        public void WhenCastAHealingSpell()
        {
            _player.CastHealingSpell();
        }

        [Given(@"I have the following magical items")]
        public void GivenIHaveTheFollowingMagicalItems(Table table)
        {
            var items = table.CreateSet<MagicalItem>();

            _player.MagicalItems.AddRange(items);
        }

        [Then(@"My total magical power should be (.*)")]
        public void ThenMyTotalMagicalPowerShouldBe(int expectedPower)
        {
            Assert.AreEqual(expectedPower, _player.MagicalPower);
        }
    }
}
