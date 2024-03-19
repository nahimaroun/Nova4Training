using System.Collections;
using System.Data.Common;
using System.Drawing;
using System.Text;

//var a = "Nahi";

//Console.WriteLine(a);

//var b = 13.5345m;

//Console.WriteLine(b);

//int hex = 0x2f;

//Console.WriteLine(hex);

//char[] chars = { 'H', 'e', 'l', 'l', 'o' };

//foreach (char c in chars)
//{
//    Console.WriteLine(c);
//}

//string path = "\\mypc\\ shared\\project";

//Console.WriteLine(path);

//String Str2 =@"this is 
//    a multiple line 
//    String!";

//Console.WriteLine(Str2);


//String Fname = "John";
//String Lname = "doe";
//int id  = 307;

//String str3 = $"hello my name is {Fname} {Lname}, my id number is {id} ";

//Console.WriteLine(str3);

//DateTime TimeNow = DateTime.Now;
//DateTime ManualTime =new DateTime(2022,10,23);

//Console.WriteLine("The time right now is :" + TimeNow.ToString());
//Console.WriteLine("The time of the incident :" + ManualTime.ToString());

//Console.WriteLine(WeekDays.Monday); 
//Console.WriteLine(WeekDays.Tuesday); 
//Console.WriteLine(WeekDays.Wednesday);

//var Wk = (WeekDays)4;
//Console.WriteLine(Wk);   

//enum WeekDays{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Friday,
//    Saturday,
//    Sunday
//}

//StringBuilder sb = new StringBuilder("Hello World!");

//var greet = sb.ToString();

//Console.WriteLine(greet);

//var student1 = new { Id = 1, FirstName = "James", LastName = "Bond" };
//var student2 = new { Id = 2, FirstName = "Conan", LastName = "Lee" };
//var student3 = new { Id = 3, FirstName = "Habib", LastName = "Kahlil" };

//Console.WriteLine(student3.FirstName);
//Console.WriteLine(student2.LastName);
//Console.WriteLine(student1);


//    dynamic MyDynamicVar = 100;
//    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

//    MyDynamicVar = "Hello World!!";
//    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

//    MyDynamicVar = true;
//    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

//    MyDynamicVar = DateTime.Now;
//    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
//}

////ternary operator

//int x = 8, y = 6;

//var result = x > y ? "x > y":"x < y";

//Console.WriteLine(result);

////Nested ternary operator
//int a = 3, b = 5;

//var result2 = a > b ? "A > B" :
//    b > a ? "B > A" :
//    b == a ? "A is equal to B" : "No Result";
//Console.WriteLine(result2);


//int x = 5;

//switch (x)
//{
//    case 5:
//        Console.WriteLine("Value of x is 5");
//        break;
//    case 10:
//        Console.WriteLine("Value of x is 10");
//        break;
//    case 15:
//        Console.WriteLine("Value of x is 15");
//        break;
//    default:
//        Console.WriteLine("Unknown value");
//        break;
//}

//String animal = "Dog";

//switch (animal)
//{
//    case "Dog":
//        Console.WriteLine("the animal is a dog.");
//        break;
//    case "Cat":
//        Console.WriteLine("The animal is a cat.");
//        break;
//    default :
//        Console.WriteLine("Unkown animal.");
//        break;

//}

//nested switch

//int x = 4;

//switch (x)
//{
//    case 1:
//        Console.WriteLine("x = 1");
//        break;
//    case 2:
//        Console.WriteLine("x = 2");
//        break;
//    case 4:
//    case 5:
//        Console.WriteLine("x = 4 or x = 5");
//        break;
//    default:
//        Console.WriteLine("x > 5");
//        break;
//}

//                  Static 

//public class StopWatch
//{
//    public static int NoOfInstances = 0;

//    // instance constructor
//    public StopWatch()
//    {
//        StopWatch.NoOfInstances++;
//    }
//}

//public static void Main(string[] args)
//{


//    StopWatch sw1 = new StopWatch();
//    StopWatch sw2 = new StopWatch();
//    Console.WriteLine(StopWatch.NoOfInstances); //2 

//    StopWatch sw3 = new StopWatch();
//    StopWatch sw4 = new StopWatch();
//    Console.WriteLine(StopWatch.NoOfInstances);//4

//    int a = StopWatch.NoOfInstances;
//    Console.WriteLine(a);

//              //     arrays      // 

//int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };

//string[] cities = new string[3] { "Mumbai", "London", "New York" };

//for (int i = 0; i < cities.Length; i++)
//{
//    Console.WriteLine(cities[i]);
//}

//for (int i = 0; i < evenNums.Length; i++)
//{
//    Console.WriteLine(evenNums[i]);
//}
//Console.WriteLine(cities[2]);

//           we can also use  foreach loop

//foreach (var item in evenNums)
//    Console.WriteLine(item);

//foreach (var city in cities)
//    Console.WriteLine(city);

//               we can also use those for arrays

//double a = evenNums.Max(); // returns 16
//int b = evenNums.Min(); // returns 6
//int c = evenNums.Sum(); // returns 55
//double d = evenNums.Average(); // returns 55

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);


//Array.Sort(evenNums); // sorts array 

//Array.Reverse(evenNums); // sorts array in descending order

//Array.ForEach(evenNums, n => Console.WriteLine(n)); // iterates array

//Array.BinarySearch(evenNums, 10);// binary search 


//             we can update an array using methods 

//int[] nums = { 1, 2, 3, 4, 5 };

//foreach (var item in nums)
//    Console.WriteLine(item);

//UpdateArray(nums);

//foreach (var item in nums)
//    Console.WriteLine(item);

//public static void UpdateArray(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//        arr[i] = arr[i] + 10;


// heres how you can make a 2d array making a 3d.4d.5d model is the similar, 3d array (int[,,])

//int[,] arr2d = new int[3, 2]{
//                                {1, 2},
//                                {3, 4},
//                                {5, 6}
//                            };

//             here we can see each element of the array independently.

//arr2d[0, 0]; //returns 1
//arr2d[0, 1]; //returns 2
//arr2d[1, 0]; //returns 3
//arr2d[1, 1]; //returns 4
//arr2d[2, 0]; //returns 5
//arr2d[2, 1]; //returns 6

//arr2d[3, 0]; //throws run-time error as there is no 4th row

//int[,,] arr3d = new int[3, 2, 2]{
//                               {{ 1, 2 }, { 3, 4 }},
//                               {{ 5, 6 }, { 7, 8 }},
//                               {{ 9, 10 }, { 11, 12 }}

//                            };

//[3, 2, 2] of arr3d1 specifies that it will contain three rows of two-dimensional array [2, 2].


// this is a 4d array 

//int[,,,] arr4d = new int[1, 2, 2, 2]{
//            {
//                { { 1, 2 }, { 3, 4 } },
//                { { 5, 6 }, { 7, 8 } }

//            }

//            };
//foreach (var item in arr4d)
//    Console.WriteLine(item);

//                      the four-dimensional array arr4d specifies [1, 1, 2, 2], which indicates that it includes one row of the three-dimensional array.

//                              jagged arrays

//  jArray can store up to two single-dimensional arrays


//int[][] jArray = new int[2][];

//jArray[0] = new int[3] { 1, 2, 3 };

//jArray[1] = new int[4] { 4, 5, 6, 7 };

//foreach (int[] i in jArray)
//{
//    foreach (int items in i)
//        Console.WriteLine(items);
//}

//                           the second bracket [,] indicates the two-dimensional array.


//int[][,] jArray = new int[2][,];

//jArray[1] = new int[2, 2] { { 1, 2 }, { 3, 4 } };

//jArray[2] = new int[2, 2] { { 5, 6 }, { 7, 8 } };

//                            indexers

//           by using indexers we can allows a class or a structure to be accessed like an array for its internal collection. 

//class StringDataStore
//{
//    private string[] strArr = new string[10]; // internal data storage

//    public string this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= strArr.Length)
//                throw new IndexOutOfRangeException("Index out of range");

//            return strArr[index];
//        }

//        set
//        {
//            if (index < 0 || index >= strArr.Length)
//                throw new IndexOutOfRangeException("Index out of range");

//            strArr[index] = value;
//        }
//    }
//}


//StringDataStore strStore = new StringDataStore();

//strStore[0] = "One1";
//strStore[1] = "Two2";
//strStore[2] = "Three3";
//strStore[3] = "Four4";
//strStore[7] = "Seven7";
//strStore[5] = "Five5";


//for (int i = 0; i < 10; i++)
//    Console.WriteLine(strStore[i]);


//                                  //  datastores

//class DataStore<T>
//{
//    private T[] _data = new T[10];

//    public void AddOrUpdate(int index, T item)
//    {
//        if (index >= 0 && index < 10)
//            _data[index] = item;
//    }

//    public T GetData(int index)
//    {
//        if (index >= 0 && index < 10)
//            return _data[index];
//        else
//            return default(T);
//    }
//}


//                   here we have a datastore that can take both int , and string values

//DataStore<string> cities = new DataStore<string>();
//cities.AddOrUpdate(0, "Mumbai");
//cities.AddOrUpdate(1, "Chicago");
//cities.AddOrUpdate(2, "London");

//DataStore<int> empIds = new DataStore<int>();
//empIds.AddOrUpdate(0, 50);
//empIds.AddOrUpdate(1, 65);
//empIds.AddOrUpdate(2, 89);

//Print(cities);

//        }
//            class DataStore<T>
//{
//    private T[] _data = new T[10];

//    public void AddOrUpdate(int index, T item)
//    {
//        if (index >= 0 && index < 10)
//            _data[index] = item;
//    }

//    public T GetData(int index)
//    {
//        if (index >= 0 && index < 10)
//            return _data[index];
//        else
//            return default(T);
//    }
//}
//public void Print<T>(T data)
//{
//    Console.WriteLine(data);
//}

//                      arraylist

//ArrayList arrayList = new ArrayList();

//                         there are 2 ways of adding data to the arraylist

// using the .add() 

//var arlist = new ArrayList();
//arlist.Add(1);
//arlist.Add("Bill");
//arlist.Add(" ");
//arlist.Add(true);
//arlist.Add(4.5);
//arlist.Add(null);

// using object initialiser syntax

//var arlist2 = new ArrayList()
//                {
//                    2, "Steve", " ", true, 5.5, null
//                };

//              a tuple is a data structure that contains a sequence of elements of different data types.

//Tuple<int, string, string> person =
//new Tuple<int, string, string>(1, "Steve", "Jobs");


//Console.WriteLine(person);

//              we can crete the tuple and we can give it value directly creating & naming it

//var tuple1 = Tuple.Create(16, "nahi", "Maroun");

//Console.WriteLine(tuple1);

//var tuple2 = Tuple.Create(16, 23, 5465, 23, 557, 4354, 2);
//Console.WriteLine(tuple2);


//              nested tuple 

//var Numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14));

//Console.WriteLine(Numbers.ToString());

//          here we used our tuple as a method 

//static void DisplayTuple(Tuple<int, string, string> person)
//{
//    Console.WriteLine($"Id = {person.Item1}");
//    Console.WriteLine($"First Name = {person.Item2}");
//    Console.WriteLine($"Last Name = {person.Item3}");
//}
//main
//var person = Tuple.Create(1, "john", "doe");
//DisplayTuple(person);


//          this is valueTuple it can hold more than  8 values

// var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

//We can assign names to the ValueTuple properties instead of having the 
//default property names like Item1, Item2 and so on.

//(int Id, string FirstName, string LastName) person = (1, "John", "Doe");
//Console.WriteLine(person.Id);   // returns 1
//Console.WriteLine(person.FirstName);  // returns "john"
//Console.WriteLine(person.LastName); // returns "doe"

// also works like that

// var person = (Id: 1, FirstName: "Bill", LastName: "Gates");

//We can  assign variables as member values

//string firstName = "john", lastName = "Doe";
//var per = (FirstName: firstName, LastName: lastName);

//ValueType can also be a parameter type or return type of a method

//public static void Main(string[] args)
//{


//    DisplayTuple((1, "Bill", "Gates"));

//}
//static void DisplayTuple((int, string, string) person)
//{
//    Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
//}

//                      //exeption handling//

//try
//{
//    Console.WriteLine("Enter a number: ");

//    var num = int.Parse(Console.ReadLine());

//    Console.WriteLine($"Squre of {num} is {num * num}");
//}

//catch
//{
//    Console.Write("Error occurred.");
//}
//finally
//{
//    Console.WriteLine("Try entering a number instead.");

//}

//                      //A shorter way of writing an if statement //

//int temp = 0;

//String StateOfMatter;

//temp += -10;

//StateOfMatter = temp < 0 ? "solid" : "liquid";

//Console.WriteLine("The state of the water is " + StateOfMatter);

//temp += 100;

//StateOfMatter = temp > 100 ? "gaz" : "liquid";

//Console.WriteLine("The state of the water is " + StateOfMatter);

//public static void EditArray(int[] array)
//{



//    Console.WriteLine("Enter the index of the element you want to change 1-5 :");
//    int index = Convert.ToInt32(Console.ReadLine()) - 1;
//    Console.Write("Enter the number :");
//    int input = Convert.ToInt32(Console.ReadLine());

//    array[index] = input;

//}



//public static void Main(string[] args)
//{
//    int[] Grades = new int[5];
//    {
//        Grades[0] = 95;
//        Grades[1] = 96;
//        Grades[2] = 97;
//        Grades[3] = 98;
//        Grades[4] = 99;
//        Grades[4] = 100;
//    }


//    EditArray(Grades);

//    for (int i = 0; i < Grades.Length; i++)
//        Console.WriteLine("Element " + (i + 1) + " = " + Grades[i]);






