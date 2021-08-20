using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> intList = new List<int>() { 5, 2, 19, 21, 11, 18, 20, 44, 109, 123, 494 };

        Console.WriteLine("Enter a number integer that is in the set of normal numbers.");
        
        try
        {

            int quotient = Convert.ToInt32(Console.ReadLine());
            foreach (int i in intList)
            
            {
                Console.WriteLine(i / quotient);
            }
        }
        
        catch (FormatException ex) //ex data type format exception
        
        {
            Console.WriteLine("Number must be element of set Normal.");
            Console.WriteLine(ex.Message + " Adding this for fun");
        }
        catch (DivideByZeroException exo)
        {
            Console.WriteLine("if you divide by 0 again I'll kill you" + exo.Message);
        }
        catch(Exception ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        finally
        {
            Console.ReadLine();
        }

        
    }
}