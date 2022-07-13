﻿namespace FoodShortage
{
    using Interfaces;
    public class Rebel : IPerson, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public int Food { get; set; }

        public void BuyFood(string name)
        {
            if (Name == name)
            {
                Food += 5;
            }
        }
    }
}