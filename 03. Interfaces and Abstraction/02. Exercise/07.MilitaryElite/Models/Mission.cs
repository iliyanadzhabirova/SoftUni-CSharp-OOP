using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Mission
    {
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }
        public string CodeName { get; set; }
        public string State { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
