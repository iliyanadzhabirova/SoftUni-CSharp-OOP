using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Models;

namespace _07.MilitaryElite.Interfaces
{
    interface IEngineer
    {
        public List<Repair> Repairs { get; set; }
    }
}