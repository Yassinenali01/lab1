using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1.oop
{
    internal class Person
    {
        //fields
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public int Age { get => age; 
            set => age = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }


        //constructor like the def _init_ in python.

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.PersonId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FavoriteColour = favoriteColour;
            this.Age = age;
            this.IsWorking = isWorking;

        }
        //methods
        public void DisplayPersonInfo()
        {

            Console.WriteLine(FirstName + LastName);
            Console.WriteLine(this.FirstName+"'s favorite colour is "+this.FavoriteColour);

        }
        public void ChangeFavoriteColour()
        {
            this.FavoriteColour = "White";
            //Console.WriteLine("your new favorite colour is"+this.favoriteColour);

        }
        public void ChangeAgeInTenYears() 
        {
            int newAge = this.Age + 10;
            Console.WriteLine( FirstName + " your age after ten years is " + newAge);
        }
        public override string ToString()
        {
            return $" person Id = {PersonId}\n first name = {FirstName}\n last name = {LastName}\n age is = {Age}\n favorite colour is = {FavoriteColour} \n is working = {IsWorking}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{PersonId} : {FirstName} {LastName}'s favorite colour is: {FavoriteColour}");
        }

       /* public void DisplayInfoAsList()
        {
            List <object> myList = new List<object>();
            myList.Add(this.personId);
            myList.Add(this.firstName);
            myList.Add(this.lastName);
            myList.Add(this.favoriteColour);
            myList.Add(this.age);
            myList.Add(this.isWorking);
            *//*Console.WriteLine(myList);*//* 
            foreach (object item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            
        }*/

        /*List<Person> people = new List<Person>();*/
        // for min and max you do for i =0 and i < 4 and i++
        // you do assign the first person age as a max age and you compare it to other ages.
        // if a bigger age is found it will be assigned to the max age
        // same thing for the min age

    }








}

