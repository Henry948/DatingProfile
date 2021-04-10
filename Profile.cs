using System;

namespace DatingProfile
{
    class Profile
    {
        /* FIELDS */
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        /* CONSTURCTORS */

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        /* METHODS */

        public string ViewProfile()
        {
            string bio = $"Name: {this.name} \nAge: {this.age} \nCity: {this.city} \nCountry: {this.country} \nPronouns: {this.pronouns}";
            bio += "\nHobbies:\n";
            foreach(string hobby in hobbies)
            {
                bio += $"- {hobby}\n";
            }
            return bio;
        }

        public string[] SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
            return hobbies;
        }
    }
}