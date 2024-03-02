﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {

        private readonly Dictionary<string, double> typesCalories;
        private const double caloriesPerGram = 2;

        private string type;
        private double weight;


        public Topping(string type, double weight)
        {
            typesCalories = new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

            Type = type;
            Weight = weight;
        }


        public string Type
        {
            get => type;
            private set
            {
                if (!typesCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get => Weight * typesCalories[Type.ToLower()] * caloriesPerGram;
        }
    }
}