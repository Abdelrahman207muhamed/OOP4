using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Abstraction
{
  //Concrete Class : Fully Implemented Class
    internal class Rectangle : Shape // : Implement Ad inhert from Shape
    {
        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
        public override double perimeter
        {
            get
            {
                return (Dim01 + Dim02) *2 ;
            }

        }

        //public override double Dim01 { get ; set ; }
        //public override double Dim02 { get ; set; }
    }

}
