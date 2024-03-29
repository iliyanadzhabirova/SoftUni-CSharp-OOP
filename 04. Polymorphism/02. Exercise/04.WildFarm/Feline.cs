﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public abstract string Breed { get; set; }
    }
}