using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of array : ");
        int size=int.Parse(Console.ReadLine());
        string[] array = new string[size];
        for(int i=0;i<size;i++)
        {
            Console.WriteLine("Enter the " +i+ "th name : ");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("names in array : ");
        for(int i=0;i<size;i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("Enter the name : ");
        string name=Console.ReadLine();
        int count=0;
        for(int i=0;i<size;i++)
        {
            if(name == array[i])
            {
                Console.WriteLine("The name is present in array and the index is : " + i);
                count++;
            }
        }  
        if(count==0) 
        {
            Console.WriteLine("The name is not present in array");
        } 
        int count2=0;
        foreach(string i in array)
        {
            if(i == name)
            {
                Console.WriteLine("The name is present in array ");
                count2++;
            }
        }
        if(count2==0) 
        {
            Console.WriteLine("The name is not present in array");
        } 
    }
}
