using CSharpSyntaxTraining.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxTraining.OOP
{
    public class Employees
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int WorkingTime { get; set; }
        public bool JobRole { get; set; }

        public string[] FullTime = new string[20];

        public string[] PartTime = new string[20];

        public int FullTimeIndex = 0;

        public int PartTimeIndex = 0;



        //public Employees()
        //{
        //    Console.WriteLine("New employee created." + "\n");
        //}

        public void Introduce(string firstname, string lastname, string jobtitle, int age, int workingtime, int salary)
        {
            FirstName = firstname;
            LastName = lastname;
            JobTitle = jobtitle;
            Age = age;
            Salary = salary;
            WorkingTime = workingtime;


            Console.WriteLine("Name : " + firstname + " " + lastname);
            Console.WriteLine("Job Title : " + jobtitle);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Months worked : " + workingtime);
            Console.WriteLine("Salary : " + salary + "\n");

        }


        public void Sort()
        {


            if (JobTitle == "Full time")
            {

                FullTime[FullTimeIndex] = FirstName + " " + LastName;
                FullTimeIndex++;
                // Console.WriteLine(FirstName + " " + LastName + " Works Full Time" + "\n");

            }

            else if (JobTitle == "Part time")
            {
                PartTime[PartTimeIndex] = FirstName + " " + LastName;
                PartTimeIndex++;
                //  Console.WriteLine(FirstName + " " + LastName + " Works Part Time" + "\n");

            }



        }

        public void PrintInfo()
        {
            Console.WriteLine("Name : " + FirstName + " " + LastName);
            Console.WriteLine("Job Title : " + JobTitle);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Months worked : " + WorkingTime);
            Console.WriteLine("Salary : " + Salary + "\n");

        }

        public void CalculateSalary()
        {

            int result = WorkingTime * Salary;

            Console.WriteLine("The total amount that employee got is :" + result + "\n");

        }








    }


}
//Employees[] employeesArray = new Employees[7];

//employeesArray[0] = new Employees();
//employeesArray[0].Introduce("Nahi", "Abou Rostom", "Full time", 21, 5, 2000);
//employeesArray[0].CalculateSalary();

//employeesArray[1] = new Employees();
//employeesArray[1].Introduce("Ali", "Baba", "Full time", 35, 5, 1750);
//employeesArray[1].CalculateSalary();

//employeesArray[2] = new Employees();
//employeesArray[2].Introduce("Thea", "Aswad", "Part time", 55, 7, 1400);
//employeesArray[2].CalculateSalary();

//employeesArray[3] = new Employees();
//employeesArray[3].Introduce("Fadi", "Kadi", "Full time", 34, 12, 700);
//employeesArray[3].CalculateSalary();

//employeesArray[4] = new Employees();
//employeesArray[4].Introduce("Tony", "Barret", "Part time", 29, 2, 1100);
//employeesArray[4].CalculateSalary();

//employeesArray[5] = new Employees();
//employeesArray[5].Introduce("Samir", "Gikell", "Full time", 47, 9, 900);
//employeesArray[5].CalculateSalary();

//employeesArray[6] = new Employees();
//employeesArray[6].Introduce("John", "Bomboclat", "Part time", 25, 18, 250);
//employeesArray[6].CalculateSalary();

//for (int i = 0; i < employeesArray.Length; i++)
//{
//    employeesArray[i].Sort();
//}



//Employees employees = new Employees();

//Console.WriteLine("Full time Employees :");
//foreach (string name in employees.FullTime)
//{
//    if (name != null)
//        Console.WriteLine(name);
//}

//Console.WriteLine("\nPart time Employees :");
//foreach (String name in employees.PartTime)
//{
//    if (name != null)
//        Console.WriteLine(name);
//}

