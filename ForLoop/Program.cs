using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        int square=0;
        Console.Write("Enter the 1st number : ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the 2st number : ");
        int endNumber = int.Parse(Console.ReadLine()); 
        for(int i=startNumber; i<=endNumber; i++)
        {
            square += (i*i);
        }
        Console.WriteLine(square);   
    }
}

