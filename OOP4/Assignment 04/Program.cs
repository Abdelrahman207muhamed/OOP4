using Assignment_OOP04.First_Project;
using Assignment_OOP04.Seconde_Project;

namespace Assignment_OOP04
{
    internal class Program
    {
        static void Main()
        {
            #region First Project
            #region 1
            //Duration duration = new Duration(2, 30, 45);

            //Console.WriteLine($"Duration :- Hours:{duration.Hours} , Minutes:{duration.Minutes} ,Seconde:{duration.Seconds} ");

            #endregion

            #region 2
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());


            //D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());


            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());


            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());
            #endregion

            #region 3
            // Duration d1 = new Duration(1, 10, 15);       
            // Duration d2 = new Duration(7800);            
            // Duration d3;

            // d3 = d1 + d2;
            // Console.WriteLine(d3); 

            // d3 = d1 + 7800;
            // Console.WriteLine(d3); 

            //d3 = 666 + d3;
            // Console.WriteLine(d3); 

            //d3 = ++d1;
            // Console.WriteLine(d3); 

            // d3 = --d2;
            // Console.WriteLine(d3); 

            // d1 = d1 - d2;
            // Console.WriteLine(d1);  

            // if (d1 > d2)
            //     Console.WriteLine("D1 is greater");
            // else
            //     Console.WriteLine("D2 is greater"); 
            #endregion
            #endregion

            #region Seconde Project
            Console.WriteLine("Add: " + Maths.Add(10, 5));
            Console.WriteLine("Subtract: " + Maths.Subtract(10, 5));
            Console.WriteLine("Multiply: " + Maths.Multiply(10, 5));
            Console.WriteLine("Divide: " + Maths.Divide(10, 5));

            #endregion
        }
    }
}
