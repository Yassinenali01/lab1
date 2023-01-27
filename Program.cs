using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab1.oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;

            person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);

            Person person2;

            person2 = new Person(2, "Gina", "James", "Green", 18, false);

            Person person3;

            person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);

            Person person4;

            person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            person2.DisplayInfo();

            Console.WriteLine(person3.ToString());

            person1.ChangeFavoriteColour();

            person1.DisplayInfo();

            person4.ChangeAgeInTenYears();

            


            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            int totalAge = 0;

            foreach (Person person in people)
               
            {
                totalAge += person.Age;
            }

            double averageAge = (double)totalAge / people.Count;
            Console.WriteLine("the average age: " + averageAge);


            // YOUNGEST PERSON 
            string youngest = "";
            int minAge = person1.Age;
            for(int i = 0;i < people.Count;i++)
            {
                if (people[i].Age < minAge)
                {
                    //minAge = people[i].Age;
                    youngest = people[i].FirstName; 
                }

            }
            Console.WriteLine("the youngest person is "+youngest );

            // OLDEST PERSON

            string oldest = "";
            int maxAge = person1.Age;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Age > maxAge)
                {
                    //maxAge = people[i].age;
                    oldest = people[i].FirstName;
                }

            }
            Console.WriteLine("the oldest person is " + oldest);

            // NAME THAT STARTS WITH AN "M"

            Console.WriteLine("Persons that their name starts with an 'M': ");
        
            foreach (Person person in people)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());

                }
            }
            // PERSON WHO LIKES BLUE.

            foreach(Person person in people)
            {
                if (person.FavoriteColour =="Blue")
                { Console.WriteLine(person.ToString()); }
            }
            Console.ReadKey();
        }
    }
}
