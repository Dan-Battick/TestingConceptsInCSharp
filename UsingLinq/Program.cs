using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
			var people = new List<Person>()
            {
				new Person("Bill", "Smith", 41),
				new Person("Sarah", "Jones", 22),
				new Person("Stacy","Baker", 21),
				new Person("Vivianne","Dexter", 19 ),
				new Person("Bob","Smith", 49 ),
				new Person("Brett","Baker", 51 ),
				new Person("Mark","Parker", 19),
				new Person("Alice","Thompson", 18),
				new Person("Evelyn","Thompson", 58 ),
				new Person("Mort","Martin", 58),
				new Person("Eugene","deLauter", 84 ),
				new Person("Gail","Dawson", 19 )
			};

			//write linq statement for people with last name that starts with the letter D
			var people1 = people.Where(p => p.LastName.StartsWith("D")).ToList();

            /*foreach (var p in people1)
            {
                Console.WriteLine(p);
            }*/

			//Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name
			var oldPerson = people.OrderByDescending(p => p.FirstName).ToList().
								Where(p => p.Age > 40).First();
            /*foreach (var s in sortedPeople)
            {
                Console.WriteLine(s);
            }*/
            Console.WriteLine($"The first person older than 40 is: {oldPerson}");
		}


		public class Person
		{
			public Person(string firstName, string lastName, int age)
			{
				FirstName = firstName;
				LastName = lastName;
				Age = age;
			}

			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Age { get; set; }

            //override ToString to return the person's FirstName LastName Age
            public override string ToString()
            {
                return $"First Name: {FirstName}; Last Name: {LastName}; Age: {Age}";
            }
        }
	}
}
