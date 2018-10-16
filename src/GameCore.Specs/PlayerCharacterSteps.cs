﻿using NUnit.Framework;
using TechTalk.SpecFlow;

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
        
        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            _player.Hit(0);
        }
        
        [Then(@"My health should be 100")]
        public void ThenMyHealthShouldBe100()
        {
            Assert.AreEqual(100, _player.Health);
        }

        [When(@"I take 40 damage")]
        public void WhenITake40Damage()
        {
            _player.Hit(40);
        }

        [Then(@"My health should be 60")]
        public void ThenMyHealthShouldBe60()
        {
            Assert.AreEqual(60, _player.Health);
        }

        [When(@"I take 100 damage")]
        public void WhenITake100Damage()
        {
            _player.Hit(100);
        }

        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.IsTrue(_player.IsDead);
        }
    }
}
