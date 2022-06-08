using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        try
        {
           
            List<int> Numbers = new List<int>() { 10, 20, 30 };
            Console.WriteLine("Please enter a whole number!");
            int divisor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                int newAnswer = Numbers[i] / divisor;
                Console.WriteLine(newAnswer);
            }
            
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Continued Execution");
            Console.ReadLine();
        }
    }
}
