namespace FakeAxeAndDummy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hero
    {
        private string name;
        private int experience;
        private IWeapon weapon;

        public Hero(string name, IWeapon weapon)
        {
            this.Name = name;
            this.Experience = 0;
            this.Weapon = weapon;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
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

        public IWeapon Weapon
        {
            get
            {
                return this.weapon;
            }
            private set
            {
                this.weapon = value;
            }
        }

        public void Attack(ITarget target)
        {
            this.Weapon.Attack(target);

            if (target.IsDead())
            {
                this.Experience += target.GiveExperience();
            }
        }
    }
}