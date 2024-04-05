using System;
namespace WhileLoop;
public class Program
{
    public static void Main(string[] args)
    {
        string option;
        
        do
        {
            Console.Write("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine(number + " is Even");
            }
            else{
                Console.WriteLine(number + " is Odd");
            }
            Console.Write("Enter yes or no to proceed with another number : ");
            option=Console.ReadLine();
            if(option != "yes" && option != "no" )
            {
                Console.WriteLine("provided input is wrong Enter valid number : ");
                option=Console.ReadLine();
                
                
            }
            
        }while(option=="yes");
    }
}
