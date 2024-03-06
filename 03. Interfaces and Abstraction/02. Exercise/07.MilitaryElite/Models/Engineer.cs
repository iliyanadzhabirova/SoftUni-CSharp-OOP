using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<Repair>();
        }

        public List<Repair> Repairs { get; set; }

        public override string ToString()
        {
            if (Repairs.Count > 0)
            {
                return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}{Environment.NewLine}Corps: {Corps}{Environment.NewLine}Repairs:{Environment.NewLine}{string.Join(Environment.NewLine, Repairs)}";
            }
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}{Environment.NewLine}Corps: {Corps}{Environment.NewLine}Repairs:";

        }
    }
}
