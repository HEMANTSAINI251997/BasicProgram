using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Program
    {
        static void Main(string[] args)//Entry point of our application
        {
            //Findsize findsize = new Findsize();
            //findsize.Size();
            //ConvertDays convertdays = new ConvertDays();
            //convertdays.CountDays();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n" + "1.find the size of data types" + "\n");
                Console.WriteLine("\n" + "2.for convert days into year,week & day" + "\n");
                Console.WriteLine("\n" + "3.for convert days into year,week & day" + "\n");
                Console.WriteLine("\n" + "4.for calculate area of circle" + "\n");
                Console.WriteLine("\n" + "5.for check number is even or not" + "\n");
                Console.WriteLine("\n" + "6.for check number is positive or not" + "\n");
                Console.WriteLine("\n" + "7.for check largest number " + "\n");
                Console.WriteLine("\n" + "8.for check Reverse number " + "\n");
                Console.WriteLine("\n" + "9.for check number is Palindrom or Not " + "\n");
                Console.WriteLine("\n" + "10.for check number all Arithmetic operations " + "\n");
                Console.WriteLine("\n" + "11.to print all ASCII values " + "\n");
                Console.WriteLine("\n" + "12.for exit" + "\n");
                Console.Write("enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Findsize findsize = new Findsize();
                        findsize.Size();
                        break;

                    case 2:
                        ConvertDays convertdays = new ConvertDays();
                        convertdays.CountDays();
                        //flag = false;
                        break;
                    case 3:
                        Swap swap= new Swap();
                        swap.SwapVariable();
                        break;
                    case 4:
                        CircleArea circlearea = new CircleArea();
                        circlearea.CircleArea_();
                        break;
                    //Program obj = new Program();
                    case 5: 
                        EvenOdd evenodd = new EvenOdd();
                        evenodd.CheckEvenOdd();
                        break;
                     case 6: 
                        PositiveNumber positivenumber = new PositiveNumber();
                        positivenumber.Checkpositivenumber();
                        break;
                    case 7: 
                        LargestNumber largestnumber = new LargestNumber();  
                        largestnumber.Checklargestnumber();
                        break;
                    case 8:
                        ReverseNumber reversenumber = new ReverseNumber();
                        reversenumber.Checkreversenumber();
                        break;
                    case 9:
                        Palindrom palindrom = new Palindrom();
                        palindrom.Checkpalindrom();
                        break;
                    case 10:
                        Arithmetic arithmetic = new Arithmetic();
                        arithmetic.Checkarithmetic();
                        break;
                    case 11: 
                        AsciiValue asciiValue = new AsciiValue();   
                        asciiValue.Checkasciivalue();
                        break;

                    case 12:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Options");
                        break;
                }
            }
        }
    }
}
