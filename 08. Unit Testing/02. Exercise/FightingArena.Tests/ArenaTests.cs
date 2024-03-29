namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Warrior warrior;
        private Warrior enemyWarrior;
        private string attacker;
        private string defender;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            warrior = new("ThunderX", 350, 1200);
            enemyWarrior = new("ZeusX", 470, 1450);
            attacker = "ThunderX";
            defender = "ZeusX";
            arena.Enroll(warrior);
            arena.Enroll(enemyWarrior);
        }

        [Test]
        public void Constructor_MakeNewArenaWithTwoWarriors()
        {
            Assert.AreEqual(2, arena.Warriors.Count);
            Assert.AreEqual(2, arena.Count);
        }

        [Test]
        public void EnrollMethod_EnrollWarriorWithExistingNameShouldThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new("ThunderX", 750, 2200)));
        }

        [Test]
        public void EnrollMethod_EnrollNewWarrior()
        {
            warrior = new("StoneX", 67, 2400);
            arena.Enroll(warrior);

            Assert.AreEqual(3, arena.Warriors.Count);
            Assert.AreEqual(3, arena.Count);

        }

        [Test]
        public void FightMethod_AttackerNameIsNullShouldThrowsException()
        {
            attacker = "StoneX";

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));

        }

        [Test]
        public void FightMethod_DefenderNameIsNullShouldThrowsException()
        {
            defender = "StoneX";

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));
        }

        [Test]
        public void FightMethod_AttackerAttackDefender()
        {
            arena.Fight(attacker, defender);

            Assert.AreEqual(730, warrior.HP);
        }
    }
}
