using CSharpSyntaxTraining.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxTraining.OOP
{

    // human parameters
    internal class human
    {
        public int ID;
        public string FirstName;
        public string LastName;
        public int Age;

        //default Constructor
        public human()
        {
            Console.WriteLine("Constructor called \\ Object created");
        }

        // Parameterized Constructor
        public human(string myFirstname, string myLastname)
        {
            FirstName = myFirstname;
            LastName = myLastname;

        }

        // Parameterized Constructor
        public human(int myID, string myFirstname, string myLastname)
        {

            ID = myID;
            FirstName = myFirstname;
            LastName = myLastname;

        }

        // Parameterized Constructor
        public human(string myFirstname, string myLastname, int myAge)
        {

            FirstName = myFirstname;
            LastName = myLastname;
            Age = myAge;

        }

        // Parameterized Constructor
        public human(int myID, string myFirstname, string myLastname, int myAge)
        {

            ID = myID;
            FirstName = myFirstname;
            LastName = myLastname;
            Age = myAge;

        }

        //public human method
        public void IntroduceMyself()
        {
            if (Age == 0 && ID != 0)
            {
                Console.WriteLine(FirstName + " " + LastName + "\nID number :" + ID + "\n");
            }

            else if (Age != 0 && ID == 0)
            {
                Console.WriteLine(FirstName + " " + LastName + "\nAge :" + Age + "\n");
            }

            else if (Age == 0 && ID == 0)
            {
                Console.WriteLine(FirstName + " " + LastName + "\n");
            }

            else
            {
                Console.WriteLine(FirstName + " " + LastName + "\nID number :" + ID + " \\ Age :" + Age + "\n");
            }

        }

    }
}


//                          //public static void Main for that class//

//human Human1 = new human(1, "Nahi", "Abou Rostom", 21);
//human Human2 = new human(2, "samer", "Abou Habib", 34);
//human Human3 = new human(3, "John", "Doe", 42);
//human Human4 = new human(4, "Khalil", "Saed");
//human Human5 = new human("Elie", "el murr", 34);
//human Human6 = new human("Moustafa", "Rayih");

//human BasicHuman = new human();

//BasicHuman.IntroduceMyself();
//Human1.IntroduceMyself();
//Human2.IntroduceMyself();
//Human3.IntroduceMyself();
//Human4.IntroduceMyself();
//Human5.IntroduceMyself();
//Human6.IntroduceMyself();