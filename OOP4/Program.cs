
namespace OOP04
{
    #region Revision
    //1.Class
    //2.Struct 
    //3.eum
    //4.Interface 
    #endregion

    internal class Program
    {
        static void Main()
        {
            #region Revision
            //Revision
            //Interfaces:Reference Type
            //Code Contract 
            //Shallow Copy VS Deep Copy 
            #endregion

            #region Abstraction
            //4.Astraction:
            //asbtrct :C# Keyword [Class- methods- properties]
            //asbtrct Class
            //asbtrct method
            //asbtrct property

            // 20 Shape

            //Shape shape = new Shape(); Invalid
            //note: Can't Create oject from Astruct Class

            //shape.GetArea();

            //Rectangle rectangle = new Rectangle() { Dim01 = 12, Dim02 = 3 };

            //rectangle .Perimeter =12 ;

            //Console.WriteLine(rectangle.perimeter);

            //Console.WriteLine(rectangle.GetArea());

            //rectangle.Print();
            #endregion

            #region Interface VS Astract Class
            //Interface VS Astract Class
            //.net 3.1 Core 
            #endregion

            #region Operator Overloadig
            ////Operator Overloadig

            ////+ - * / % < > <= >= != == && || ^ >>

            //// +

            ////int X = 3 + 4;
            ////string Y = " Hello" + "World";

            ////Complex number : Real +Imag

            ////4+3 i 

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            ////Console.WriteLine(C01);
            ////Console.WriteLine(C02);

            ////Complex C03 = C01 - C02;

            ////Console.WriteLine(C03);

            ////++ --
            ////Unary Operator 

            ////int X = 12;
            ////X++;
            ////Console.WriteLine(X);

            ////Console.WriteLine(C01);
            ////Complex c03 = C01--;

            ////Console.WriteLine(c03);


            //if (C01 >= C02)
            //{
            //    Console.WriteLine("C01 Is Greater than C02");
            //}
            //else
            //{  
            //    Console.WriteLine("C01 Is not Greater than C02");
            //}

            //bool X = true || true; 
            #endregion

            #region User-Defined Casting & Manual Mappig
            //double X = 12;
            //int Y = (int)X;
            //(int) : Casting Complex number to String

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };


            //string s = (string) C01;
            ////(string): Convert Complex number To string

            ////Operator Overloading 
            ////User-Defined Casting Operator

            //Console.WriteLine(s);

            //int X = (int)C01;

            //Console.WriteLine(X);


            //int X = (int)new Complex() { Real = 4,Imag = 7 };

            //Mapping : Convert From Datatype To Datatype

            //code First
            //Db First

            //User [Id ,name, Email,Password,Username, phonenumer]

            //UserViewModel
            //UserDto
            //[name,email,phonenumber]

            //User user = new User(); //  from Db

            ////Manual Mapping
            //UserDto userDto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    Phonenumer = user.Phonenumer

            //};

            //Castig Operator
            //Automapper :Mappig Automatic

            #endregion

            #region Static
            //static : C# Key WOrd [Class - Method- Property - Constructor - Attributes]
            //static Class
            //static Method
            //static Property
            //static Constructor
            //static Attributes

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CmToInch(254));//100
            //Console.WriteLine(U02.CmToInch(254));//100
            //Console.WriteLine(U03.CmToInch(254));//100

            //Console.WriteLine(Utilities.CmToInch(254));//100
            //Console.WriteLine(Utilities.CmToInch(254));//100
            //Console.WriteLine(Utilities.CmToInch(254));//100

            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);
            //Console.WriteLine(U03.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);

            //Utilities u1 = new Utilities();

            #endregion

            #region sealed
            //Sealed : C# Key Word [Class - Method - Property ] 

            #endregion

            #region Partial
            ////Partial 
            //Employee employee = new Employee();
            //employee . 
            #endregion
        }
    }
}
