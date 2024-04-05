using System;
namespace StringManipulation;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Main String : ");
        string mainSting = Console.ReadLine();
        Console.Write("String to be searched : ");     
        string subSting = Console.ReadLine();
        string[] array = mainSting.Split(subSting);
        int n=array.Length-1;
        int count=0;
        foreach(string i in array )
        {
            count++;
        }
        Console.Write("string searched count is ");
        Console.WriteLine(count-1);
    }
}
