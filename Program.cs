using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace Y9_DEC_TO_BIN_SKELETON 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode) 
            int myInt = 0; //just for testing single stepping 
            string myString = "12"; //watch me being cast from string to int 
            string modMyString = myString.Insert(0, "Number is "); 
            Console.WriteLine(modMyString); 
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int 
            Console.WriteLine(myString);
            Console.WriteLine(numberConversion(210,2));


            //MAIN:  NUMBER CONVERSION PROGRAM 

            //CODE GOES HERE 
        }

        // static void means the function will not return a value so it does not need a data type
        //  this function DOES return a value so the method must have a data type
     static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            int remainderofnum = 0;
            string result = "";
            while(number != 0)
            {
                remainderofnum = number % numberbase;
                number = number / 2;
                result = result.Insert(0,Convert.ToString(remainderofnum));
            }
               


            return result; //REMOVE THE RED LINE! 
        }
    } 
} 

// while number not equal to 0 repeat
// number/2 
