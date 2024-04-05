using System;
namespace WhileLoop;
public class Program
{
    public static void Main(string[] args)
    {
        int startNumber=0 ;
        int endNumber=25;
        while(startNumber<endNumber)
        {
            if(startNumber%2==0)
            {
                Console.WriteLine(startNumber);
            }
            startNumber++;
            
        }

        Console.Write("Enter a number : ");
        bool isvalid=int.TryParse(Console.ReadLine(),out int output);
        while(!isvalid)
        {
            Console.Write("Invalid number Enter again : ");
            isvalid=int.TryParse(Console.ReadLine(),out output);
        }
        Console.WriteLine(output);
    }
}
