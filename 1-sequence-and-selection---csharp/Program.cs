using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_sequence_and_selection___csharp
{
    class Program
    {
        static void HelloWorld()
        {
            Console.WriteLine("He       !");
        }

        static void HelloUser()
        {
            string userName;

            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Hello {0}", userName);
        }
        
        
        static double AreaCalc(double length, double width) // Defining the PARAMETERS length and width with their data-types
        {
            double areaCalculation = length * width;

            return areaCalculation; // 
        }
        static void PerimeterCalc()
        {

        }
        static void BiggerandBigger()
        {

            for (int i = 0; i < 10; i++)
			{
                Console.WriteLine("{0}",i);
			}
        }
        static void FormChooser()
        {

        }
        static void VATCalculator()
        {

        }
        static void VolumeandSurfaceCalc()
        {
        
        }
        static void MiniCalc()
        {
           
        }
        static void CafeAdder()
        {

        }
        static void Main(string[] args)
        {
            //1.01. Hello World

                Console.WriteLine("1.01. Hello World task");
                HelloWorld(); // Calling the HelloWorld method (a type of subroutine)

                Console.ReadLine();

            //1.02. Hello User

                Console.WriteLine("1.02. Hello User task");
                HelloUser();
                Console.ReadLine();

            //1.03 AreaCalc

                // This task has been laid out so that you are passing values from the MAIN method (a form of subroutine) 
                // to the AreaCalc method (a form of subroutine).

                Console.WriteLine("1.03 AreaCalc task");
                double userNumber1; // A double is a way to represent a real number - a double is more precise than a float
                double userNumber2;
                double areaCalcResult;

                Console.WriteLine("Enter your first number: ");
                userNumber1 = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Enter your second number: ");
                userNumber2 = Convert.ToDouble(Console.ReadLine());

                areaCalcResult = AreaCalc(userNumber1, userNumber2); // ARGUMENTS userNumber1, userNumber2 passed to AreaCalc method

                Console.WriteLine("Area calculation for {0} and {1} is {2}", userNumber1, userNumber2, areaCalcResult);

                Console.ReadLine();

            //1.04 PerimeterCalc

                Console.WriteLine("1.04 PerimeterCalc task");
                PerimeterCalc();
                Console.ReadLine();

            //1.05 Bigger and Bigger

                Console.WriteLine("1.05 Bigger and Bigger task");
                BiggerandBigger();
                Console.ReadLine();

            //1.06 Form Chooser

                Console.WriteLine("1.06 Form Chooser task");
                FormChooser();
                Console.ReadLine();

            //1.07 VAT Calculator

                Console.WriteLine("1.07 VAT Calculator task");
                VATCalculator();
                Console.ReadLine();

            //1.08 Volume and Surface Calc

                Console.WriteLine("1.08 Volume and Surface Calc task");
                VolumeandSurfaceCalc();
                Console.ReadLine();

            //1.09 Mini - Calc

                Console.WriteLine("1.09 Mini - Calc task");
                MiniCalc();
                Console.ReadLine();

            //1.10.Café Adder

                Console.WriteLine("1.10.Cafe Adder task");
                CafeAdder();
                Console.ReadLine();
        }
    }
}
