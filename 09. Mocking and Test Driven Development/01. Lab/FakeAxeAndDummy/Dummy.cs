namespace FakeAxeAndDummy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Dummy : ITarget
    {
        private int health;
        private int experience;

        public Dummy(int health, int experience)
        {
            this.Health = health;
            this.Experience = experience;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value;
            }
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }
            private set
            {
                this.experience = value;
            }
        }

        public void TakeAttack(int attackPoints)
        {
            if (IsDead())
            {
                throw new InvalidOperationException("Dummy is dead.");
            }

            this.Health -= attackPoints;
        }

        public int GiveExperience()
        {
            if (!IsDead())
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.Experience;
        }

        public bool IsDead()
        {
            return this.Health <= 0;
        }
    }
}