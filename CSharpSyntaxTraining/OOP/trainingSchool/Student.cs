using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxTraining.OOP.trainingSchool
{
    internal class Student : prs
    {

        public void Study()
        {
            Console.WriteLine("I'm studing.");
        }

        public void Greet()
        {
            Console.WriteLine("Hello everyone. My name is {0}, I'm {1} years old, Student", Name, Age);
        }
    }
}
