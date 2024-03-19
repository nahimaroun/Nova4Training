using System;
using System.Collections;
using System.Collections.Immutable;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using CSharpSyntaxTraining.OOP;
using CSharpSyntaxTraining.OOP.trainingSchool;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpSyntaxTraining
{


    class Program
    {


        public static void Main(string[] args)
        {
            //problem 1 :

            //int f = 35;
            //int g = 63;
            
            //Dictionary<char,int> variables = new Dictionary<char,int>();

            //variables.Add('g',g);

            //variables.Add('f',f);


            //if (g > f)
            //{

            //    foreach (var kvp in variables)
            //    {
            //        if (kvp.Value == g)
            //        {
            //            Console.WriteLine(kvp.Key + " is bigger"); 
            //        }

            //    } 
            //}
            //else if (g < f)
            //{
            //    foreach (var kvp in variables)
            //    {
            //        if (kvp.Value == f)
            //        {
            //            Console.WriteLine(kvp.Key + " is bigger");
            //        }
            //    }
            //}
            //else
            //    {
            //        Console.WriteLine("Neither");
            //    }


            //-----------------------------------------------------------




            //problem 2 :

            //int[] arr1 = { 2, 3, 4, 5, 6 };
            //int[] arr2 = { 0, 2, 3, 4, 7 };
            //bool isTrue = false;


            //if (arr1.Min() > arr2.Min())
            //{
            //    if (arr1.Max() < arr2.Max())
            //    { isTrue = true; }

            //}
            //else
            //{
            //    isTrue = false;
            //}
            
            //Console.WriteLine(isTrue);

            //----------------------------------------------------------



            //problem 3 :

            //int num;
            //int length;

            //Console.Write("Enter the number : ");
            //num = Convert.ToInt32(Console.ReadLine());


            //Console.Write("How many times to you want to multiply it : ");
            //length = Convert.ToInt32(Console.ReadLine());

            //int[] arr3 = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    arr3[i] = num * i;
            //}


            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write((arr3[i] += num) + "    ");
            //}

            //---------------------------------------------------------


            // problem 4 :

            //string Greet = "HEllo World";

            //char[] charArray = Greet.ToCharArray();

            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    if (char.IsLower(charArray[i]))
            //    {
            //        charArray[i] = char.ToUpper(charArray[i]);
            //    }
            //    else if (char.IsUpper(charArray[i]))
            //    {
            //        charArray[i] = char.ToLower(charArray[i]);
            //    }
            //}
            //Console.WriteLine(charArray);

            //--------------------------------------------

            //problem 5 :

            //int numb = 20;
            //bool isPrime = true;

            //for (int i = 2; i < numb; i++)
            //{
            //    if (numb % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }

            //}

            //if (isPrime)
            //{
            //    Console.WriteLine(numb + " is a prime number.");
            //}

            //else
            //{
            //    Console.WriteLine(numb + " isn't a prime number.");

            //    while (isPrime == false)
            //    {

            //        for (int i = 2; i < numb; i++)
            //        {
            //            if (numb % i == 0)
            //            {
            //                numb++;
            //            }



            //        }
            //        Console.WriteLine(numb + " is the closest prime number.");
            //        break;
            //    }

            //}


            //---------------------------------------------------

            //problem 6 : 

            //string text = "qwertyuioplkjhgfdsaq";

            //Dictionary<char, int> charFrequency = new Dictionary<char, int>();


            //foreach (char c in text)
            //{
            //    if (charFrequency.ContainsKey(c))
            //    {
            //        charFrequency[c]++;
            //    }
            //    else
            //    {
            //        charFrequency[c] = 1;
            //    }
            //}


            //int maxFrequency = charFrequency.Values.Max();


            //List<char> maxChars = new List<char>();

            //foreach (var pair in charFrequency)
            //{
            //    if (pair.Value == maxFrequency && pair.Value != 1)
            //    {
            //        maxChars.Add(pair.Key);
            //    }
            //}

            //if (maxChars.Count == 1)
            //{
            //    Console.WriteLine(maxChars[0]);
            //}
            //else if (maxChars.Count > 1)
            //{
            //    Console.WriteLine(string.Join(",", maxChars));
            //}
            //else 
            //{
            //    Console.WriteLine("No Repetition");
            //}

            // ------------------------------------------------------



            //problem 7 : not solved completetly

            //List<List<int>> ThreeSum(int[] nums)
            //{
            //    List<List<int>> result = new List<List<int>>();

            //    Array.Sort(nums);

            //    for (int i = 0; i < nums.Length - 2; i++)
            //    {
            //        if (i == 0 || nums[i] != nums[i - 1])
            //        {
            //            int left = i + 1;

            //            int target = -nums[i];

            //            while (left < nums.Length - 1)
            //            {
            //                int sum = nums[i] + nums[left] + nums[left + 1];

            //                if (sum == 0)
            //                {
            //                    result.Add(new List<int> { nums[i], nums[left], nums[left + 1] });
            //                }
            //                left++;

            //            }

            //        }
            //    }

            //    return result;
            //}

            //void PrintResults(List<List<int>> result)
            //{
            //    foreach (var list in result)
            //    {
            //        Console.Write("{ ");
            //        Console.Write(string.Join(", ", list));
            //        Console.WriteLine(" }");
            //    }
            //    Console.WriteLine();
            //}


            //int[] numbs1 = { 2, -1, -1, 1, 0 };
            //int[] numbs2 = { 0, 0, 0, 5, -5 };
            //int[] numbs3 = { 1, 2, 3 };
            //int[] numbs4 = { 1, 2, -3, 5, -2 };
            //int[] numbs5 = { };

            //PrintResults(ThreeSum(numbs1));
            //PrintResults(ThreeSum(numbs2));
            //PrintResults(ThreeSum(numbs3));
            //PrintResults(ThreeSum(numbs4));
            //PrintResults(ThreeSum(numbs5));







            //------------------------------------------------------



            //problem 8 :

            //long[] MaxMin(long num)
            //{
            //    string numStr = num.ToString();
            //    long max = num;
            //    long min = num;

            //    for (int i = 0; i < numStr.Length; i++)
            //    {
            //        for (int j = i + 1; j < numStr.Length; j++)
            //        {

            //            string NewNumStr = Swap(numStr, i, j);

            //            long modifiedNum = long.Parse(NewNumStr);


            //            if (NewNumStr.Length > 1 && NewNumStr[0] == '0')   //check for zeros.    
            //                continue; 

            //            if (modifiedNum > max)
            //            {
            //                max = modifiedNum;
            //            }
            //            else if (modifiedNum < min)
            //            {
            //                min = modifiedNum;
            //            }
            //        }
            //    }

            //    return new long[] { max, min };
            //}


            //string Swap(string numStr, int i, int j)
            //{
            //    char[] numArray = numStr.ToCharArray();
            //    char temp = numArray[i];
            //    numArray[i] = numArray[j];
            //    numArray[j] = temp;
            //    return new string(numArray);
            //}


            //long[] result1 = MaxMin(12340);
            //Console.WriteLine(result1[0] + ", " + result1[1]);

            //long[] result2 = MaxMin(98761);
            //Console.WriteLine(result2[0] + ", " + result2[1]);

            //long[] result3 = MaxMin(84681649);
            //Console.WriteLine(result3[0] + ", " + result3[1]);

            //long[] result4 = MaxMin(11321);
            //Console.WriteLine(result4[0] + ", " + result4[1]);



            //------------------------------------------------------




        }
    } 
}




