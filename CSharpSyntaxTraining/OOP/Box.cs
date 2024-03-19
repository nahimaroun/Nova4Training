using CSharpSyntaxTraining.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxTraining.OOP
{
    internal class Box
    {
        //private int Width;

        //public int Height;

        //public int Volume;

        private int Length = 3;

        public int Height { get; set; }

        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return Length * Height * Width;
            }
        }

        public void Setlength(int Length)
        {
            if (Length < 0)
            {
                throw new Exception("The length cannot be negative.");
            }
            this.Length = Length;
        }

        public int Getlength()
        {
            return Length;
        }



        //public Box(int Flength, int Fwidth, int Fheight)
        //{
        //    Length = Flength;
        //    Width = Fwidth;
        //    Height = Fheight;
        //}

        //public Box(int Flength, int Fwidth, int Fheight, int volume)
        //{
        //    Length = Flength;
        //    Width = Fwidth;
        //    Height = Fheight;
        //    Volume = volume;
        //}

        public int GetVolume()
        {
            return Width * Height * Length;
        }

        public void CalculateRadius()
        {
            Console.WriteLine("Length : " + Length + " \\ Width : " + Width + " \\ Height : " + Height);

            Console.WriteLine("Volume : " + Volume);
        }


    }
}


//              public static void main for that code 


//Box Box1 = new Box();

//// //Box1.width = 5; 

//Box1.Height = 5;

////   //this will not work when int Length is private.

////  // Box1.Length =5;

//Box1.Setlength(4);

//Box1.Width = 4;

//Box1.CalculateRadius();

//Console.WriteLine("\nThe Volume is : " + Box1.GetVolume());

////  //this will not work when int Length is private.

////  //Console.WriteLine("the length is " + Box1.Length);

//// //Even if the Length is private we access it using getters and setters.


