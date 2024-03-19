using CSharpSyntaxTraining.OOP.trainingSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxTraining.OOP.trainingSchool
{
    internal class prs
    {
        protected int Age { get; set; }
        protected string Name { get; set; }


        public void SetAge(int age)
        {
            Age = age;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public void Greet()
        {
            Console.WriteLine("Hello everyone. My name is {0}, I'm {1} years old. Normal person", Name, Age);
        }

    }
}
//Student student1 = new Student();

//prs prs1 = new prs();

//Professor prof1 = new Professor();

//prs1.SetName("Nahi");
//prs1.SetAge(35);
//prs1.Greet();

//student1.SetAge(19);
//student1.SetName("Julie");
//student1.Greet();

//prof1.SetName("Mr.Johnny");
//prof1.SetAge(49);
//prof1.Greet();
//prof1.Teach();
