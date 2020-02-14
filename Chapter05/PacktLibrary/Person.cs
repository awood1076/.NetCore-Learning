using System;

namespace Packt.CS7
{
    public class Person : Object //Object is a C# keyword for System.Object. Every class inherits from System.Object, but this is how to explicitly inherit from a class. System.Object is the super class, Person is the derived or subclass
    {
        //these are fields
        public string Name;
        public DateTime DateOfBirth;
    }
}
