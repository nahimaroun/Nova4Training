using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxTraining.OOP
{
    internal class person
    {
        //Private fields 
        private string FirstName;
        private string JobTitle;
        private int Salary = 20000;

        //public fields

        public int Age { get; set; }
        // public Properties that exposes JobTilte safely

        public string jobTitle
        {

            get { return JobTitle; }
            set { JobTitle = value; }

        }

        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public person()
        {
            Console.WriteLine("New user created!");
        }

        public void UserPrint()
        {
            Console.WriteLine("Username : " + FirstName);
            Console.WriteLine("Job Title : " + JobTitle);
            Console.WriteLine("Age : " + Age);
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend == true)
            {
                SharePrivateInfo();
            }
            else
            {
                Console.WriteLine("Sorry, you are not my friend.\n");
            }
        }

        private void SharePrivateInfo()
        {
            Console.WriteLine("My salary is : " + Salary + "\n");
        }
    }
}

//              public static void main

//int i = 0;

//person person1 = new person();

//person1.firstName = "nahi";

//person1.jobTitle = "Software Developer";

//person1.Age = 23;

//person1.UserPrint();

//person1.Introducing(false);

//person person2 = new person();
//person2.UserPrint();

//Console.WriteLine("");

//person person3 = new person();
//person3.UserPrint();