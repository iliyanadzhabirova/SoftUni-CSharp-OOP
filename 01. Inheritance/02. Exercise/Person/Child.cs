﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) 
            : base(name, age)
        {
        }
        public override  int Age 
        {
            get => base.Age;
            set
            {
                if (value>15)
                {
                    throw new ArgumentException("A child cannot be older than 15");
                }
                base.Age = value;
            }
        }
    }
}
