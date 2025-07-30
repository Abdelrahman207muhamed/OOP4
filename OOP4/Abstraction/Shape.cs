using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Abstraction
{
    //Abstract Class :partial Class [not  Fully implementet Class]
    //Concret Class  : Fully implementet Class

    internal abstract class Shape
    {
        public  double Dim01 { get; set; }
        public  double Dim02 { get; set; }

        //Abstract Method : Like Virtual Method Without From Implementation
        public abstract double GetArea();

        //Make This Method Astractoin


        //Astract Property :Like Virtual property Without From Implementation
        public abstract double perimeter { get; }


        public void print()
        {
            Console.WriteLine("Iam Shape");
        }
    }
}
