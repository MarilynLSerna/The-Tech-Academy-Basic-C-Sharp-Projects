﻿using System;

namespace PolymorphismApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

