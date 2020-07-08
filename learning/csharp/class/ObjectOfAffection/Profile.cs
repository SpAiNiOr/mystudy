using System;

namespace DatingProfile
{

    class Profile
    {
        // We are using the filed directly.
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // for the private the member, we can use the construtor to set values.
        public Profile(string name, int age, string city, string country, string pronouns = "they", string[] hobbies = null)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = hobbies;
        }

        public string ViewProfile()
        {
            string profiles = $"{name} {age} {city} {country} {pronouns}";
            foreach (string n in hobbies)
            {
                profiles += $" {n}";
            }
            return profiles;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }



}
