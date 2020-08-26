using System;

namespace CSharp0008_ConditionalStatements
{
    class CSharp0008_ConditionalStatements
    {
        static void Main(string[] args)
        {

            Console.Write("The monthly income is ");
            int monthly_income = int.Parse(Console.ReadLine());
            float monthly_tax;

            if (monthly_income < 1000)
            {

                monthly_tax = (float)(0.0 * monthly_income);
                Console.WriteLine("S/He will not pay any tax.");
                Console.WriteLine(String.Format("{0:0.00}", monthly_tax) + " TL.");
            }
            else if (monthly_income >= 1000 && monthly_income < 3000)
            {

                monthly_tax = (float)(0.1 * monthly_income);
                Console.Write("S/He should pay ");
                Console.WriteLine(String.Format("{0:0.00}" , monthly_tax) + " TL.");
            }
            else
            {

                monthly_tax = (float)(0.15 * monthly_income);
                Console.Write("S/He should pay ");
                Console.WriteLine(String.Format("{0:0.00}", monthly_tax) + " TL.");
            }

            Console.WriteLine("You have to do it for living free in this country. :D");
        }
    }
}
