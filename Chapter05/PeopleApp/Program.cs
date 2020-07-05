using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Bob is instantiated and then his fields are set later
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // equivalent to bob.BucketList = (WondersOfTheAncientWorld)18 due to byte
            bob.Children.Add(new Person {Name = "Alfred"});
            bob.Children.Add(new Person {Name = "Zoe"});
            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}.",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );
            WriteLine(
                format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder
            );
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            //using a for loop to get the name of the children
/*             for (int child = 0; child < bob.Children.Count; child++) {
                WriteLine($" {bob.Children[child].Name}");
            } */
            //using a foreach loop to iterate through the list
            foreach(Person child in bob.Children) {
                WriteLine($" {child.Name}");
            }
            WriteLine($"{bob.Name} is a {Person.Species}");
            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");


            //Alice is instantiated with the fields set at that time
            var alice = new Person {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine(
                format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
            );

            BankAccount.InterestRate = 0.012M; //store a shared value
            var jonesAccount = new BankAccount();
                jonesAccount.AccountName = "Mrs. Jones";
                jonesAccount.Balance = 2400;
            decimal jonesInterest = jonesAccount.Balance * BankAccount.InterestRate;
            WriteLine($"{jonesAccount.AccountName} earned {jonesInterest:C} interest.");

            var gerrierAccount = new BankAccount();
                gerrierAccount.AccountName = "Ms. Gerrier";
                gerrierAccount.Balance = 98;
            decimal gerrierInterest = (gerrierAccount.Balance * BankAccount.InterestRate);
            WriteLine($"{gerrierAccount.AccountName} earned {gerrierInterest:C} interest.");


            var blankPerson = new Person();
            WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at " + 
                $"{blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}.");
            
            var gunny = new Person("Gunny", "Mars");
            WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at " +
            $"{gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}.");

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());
            //item syntax
            (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
            //named syntax
            var fruitNamed = bob.GetNamedFruit();
            WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");
            //using the item1, item2 syntax
            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            //set these equal to the class fields
            var thing2 = (bob.Name, bob.Children.Count);
            //can reference it using those automatically
            WriteLine($"{thing2.Name} has {thing2.Count} children.");

            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Emily"));
            WriteLine(bob.OptionalParameters());
            WriteLine(bob.OptionalParameters("Jump!", 98.5));
            WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
            WriteLine(bob.OptionalParameters("Poke!", active: false));

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            int d = 10;
            int e = 20;

            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            //simplified C# 7.0 syntax for the out parameter
            bob.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");

            var sam = new Person {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);
            sam.FavoriteIceCream = "Chocolate Fudge";
            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
            sam.FavoritePrimaryColor = "Red";
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
            sam.Children.Add(new Person { Name = "Charlie" });
            sam.Children.Add(new Person { Name = "Ella" });
            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");
            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");
        }
    }
}
