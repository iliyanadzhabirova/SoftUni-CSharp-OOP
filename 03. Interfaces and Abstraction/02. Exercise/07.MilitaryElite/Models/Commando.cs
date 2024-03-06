using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string firstName, string lastName, string id, decimal salary, string corps)
            : base(firstName, lastName, id, salary, corps)
        {
            Missions = new List<Mission>();
        }

        public List<Mission> Missions { get; set; }

        public override string ToString()
        {
            if (Missions.Count > 0)
            {
                return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}{Environment.NewLine}Corps: {Corps}{Environment.NewLine}Missions:{Environment.NewLine}{string.Join(Environment.NewLine, Missions)}";
            }

            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}{Environment.NewLine}Corps: {Corps}{Environment.NewLine}Missions:";
        }
    }
}