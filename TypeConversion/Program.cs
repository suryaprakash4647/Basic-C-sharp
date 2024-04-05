using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your Age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1 : ");
        float mark1 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2 : ");
        float mark2 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3 : ");
        float mark3 = float.Parse(Console.ReadLine());
        Console.Write("Enter your Grade : ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter your Mobile number : ");
        long mobile = long.Parse(Console.ReadLine());
        Console.Write("Enter your MailId : ");
        string mailid= Console.ReadLine();
        float total = mark1+mark2+mark3;
        float avg = (mark1+mark2+mark3)/3;

        Console.WriteLine("Trainee Details Are : ");
        Console.WriteLine("Name: "+ name);
        Console.WriteLine("Age:"+ age);
        Console.WriteLine("Mobile: "+ mobile);
        Console.WriteLine("Mark1: "+ mark1);
        Console.WriteLine("Mark2: "+mark2);
        Console.WriteLine("Mark3: "+mark3);
        Console.WriteLine("Total: "+ total);
        Console.WriteLine("Average : "+ avg);
        Console.WriteLine("Grade : "+ grade);
        Console.WriteLine("Mailid : "+ mailid);
    }
}
