using System;
using NETReflection_Attributes.myCustomAttributes;

namespace NETReflection_Attributes
{
    [WhoWrote("Gaspar Acevedo Zain", 1.0)]
    public class Person
    {
        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public string FirstName { get; set; }

        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public string LastName { get; set; }

        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public string Country { get; set; }

        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public DateTime BirthDate { get; set; }
        
        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public Person(string FirstName, string LastName, string Country, DateTime BirthDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Country = Country;
            this.BirthDate = BirthDate == null? DateTime.Now : BirthDate;
        }

        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public string IntroduceYourself()
        {
            return string.Format("Hello!!! I'm {0} {1}. I'm from {2} and my current age is {3}", this.FirstName, this.LastName, this.Country, this.GetAge());
        }

        [WhoWrote("Gaspar Acevedo Zain", 1.0)]
        public int GetAge()
        {
            return Math.Abs(DateTime.Now.Year-this.BirthDate.Year);
        }
    }
}