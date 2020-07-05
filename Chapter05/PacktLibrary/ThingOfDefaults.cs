using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingofDefaults {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;
        public ThingofDefaults() { 
            Population = default; //C# 7.1 and later
            When = default;
            Name = default;
            People = default;
        }
    }
}