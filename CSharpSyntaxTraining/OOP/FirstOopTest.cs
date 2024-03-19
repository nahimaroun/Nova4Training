using System.Collections;
using System.Reflection;

//                          //Inheritance//

//namespace CSharpSyntaxTraining
//{
// here we used oop to join 2 classes with each other by making the Employee class 
// inherit firstname and lastname from the person class   
//    class Person
//    {
//        public int Id { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//    }

//    class Employee : Person
//    {
//        public string CompanyName { get; set; }
//        public decimal Salary { get; set; }
//    }

//    class FirstOopTest
//    {
//        public static void Main(string[] args)
//        {

//            Employee emp = new Employee();
//            emp.FirstName = "John";
//            emp.LastName = "Doe";
//            emp.CompanyName = "Nova4";
//            emp.Salary = 10000;


//            Console.WriteLine(emp.FirstName);
//            Console.WriteLine(emp.LastName);
//            Console.WriteLine(emp.CompanyName);
//            Console.WriteLine(emp.Salary);

//        }
//    }

//}

//---------------------------------------------------------------------------------

//class Person
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//}

//class Employee : Person
//{
//    public string CompanyName { get; set; }
//    public decimal Salary { get; set; }
//}

//public class FirstOopTest
//{
//    public static void Main()
//    {
//        Person per1 = new Person();
//        per1.Id = 1; //valid
//        per1.FirstName = "James"; //valid
//        per1.LastName = "Bond"; //valid

//        //per1.CompanyName; // not supported
//        //per1.Salary;  // not supported

//        Person per2 = new Employee();
//        per2.Id = 2; //valid
//        per2.FirstName = "Bill"; //valid
//        per2.LastName = "Gates"; //valid

//        //per2.CompanyName; // not supported
//        //per2.Salary;  // not supported

//        Employee emp = new Employee();
//        emp.Id = 1; //valid
//        emp.FirstName = "Steve";//valid
//        emp.LastName = "Jobs";//valid
//        emp.CompanyName = "XYZ"; //valid
//        emp.Salary = 10000; //valid 

//        //invalid, can't assign base type to derived type
//        //Employee emp = new Person();
//        Console.WriteLine(emp.FirstName);
//        Console.WriteLine(emp.LastName);
//        Console.WriteLine(emp.CompanyName);
//        Console.WriteLine(emp.Salary);
//        Console.WriteLine(per1.FirstName);
//        Console.WriteLine(per1.LastName);
//        Console.WriteLine(per1.Id);
//        Console.WriteLine(per2.FirstName);
//        Console.WriteLine(per2.LastName);
//        Console.WriteLine(per2.Id);
//    }
//}

//----------------------------------------------------------------------------------------------

//namespace CSharpSyntaxTraining
//{
//    class FirstOopTest
//    {
//        public static void Main(string[] args)
//        {
            

//        }

//        class ConsolePrinter
//        {
//            public void Print(string str)
//            {
//                Console.WriteLine(str);
//            }

//            public void Print(string str1, string str2)
//            {
//                Console.WriteLine($"{str1}, {str2}");
//            }

//            public void Print(string str1, string str2, string str3)
//            {
//                Console.WriteLine($"{str1}, {str2}, {str3}");
//            }
//        }

//    }
//}


