using System;
namespace SwitchCase;
public class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Enter the input 1 : ");
        int number1= int.Parse(Console.ReadLine());
        Console.Write("Enter the input 2 : "); 
        int number2= int.Parse(Console.ReadLine());
        Console.Write("Enter the operation : "); 
        string operation = Console.ReadLine();
        switch(operation)
        {
            case "+":
            {
                Console.WriteLine(number1+number2);
                break;
            }
            case "-":
            {
                Console.WriteLine(number1-number2);
                break;
            }
            case "*":
            {
                Console.WriteLine(number1*number2);
                break;
            }
            case "/":
            {
                Console.WriteLine(number1/number2);
                break;
            }
            case "%":
            {
                Console.WriteLine(number1%number2);
                break;
            }
            default:
            {
                Console.WriteLine("Operation is Invalid");
                break;
            }
        }
    }  
}
