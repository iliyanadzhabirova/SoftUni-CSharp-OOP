using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Models;

namespace _07.MilitaryElite.Interfaces
{
    public interface ICommando
    {
        public List<Mission> Missions { get; set; }
    }
}