using System;

namespace CSharpOO
{
    internal class CSharpOOClass
    {
        private static void Main(string[] args)
        {
            var person1 = new Person("Male","Vincent","Taylor", "China", 23);
            var person2 = new Person("Female","Vivian","Johnson", "United States", 22);
            
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine("\n");
            Console.WriteLine(person1.firstName +" "+person1.lastName + " is " + person1.CompareAge(person2) + " " + person2.firstName +" "+person2.lastName +".");
        }
    }

    internal class Person
    {
		public string firstName;
    	public string lastName;
        public string Sex { get; set; }
        private string Location { get; set; }
        private int Age { get; set; }

		
        public Person(string sex, string firstName, string lastName, string location, int age)
        {
        	this.firstName = firstName;
        	this.lastName = lastName;
            this.Sex = sex;
            this.Location = location;
            this.Age = age;
        }

  		public string FirstName => this.firstName;
    	public string LastName => this.lastName;

        public string CompareAge(Person p)
        {
            if (Age == p.Age)
            {
                return "the same age as";
            }
            return Age > p.Age ? "older than" : "younger than";
        }
		
		
   	 	public override string ToString()
    	{
        	return $"{this.firstName} {this.lastName} is a {this.Age} years old {this.Sex} in {this.Location}.";
    	}
    }
}