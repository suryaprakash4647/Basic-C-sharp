using System;

namespace MethodPractice;
public class Program
{
    public static void Main(string[] args)
    {
          string repeat ;
          do{
          Console.Write("Enter the 1st Number : ");
          int a= int.Parse(Console.ReadLine()) ;
          Console.Write("Enter the 2st Number : ");
          int b=int.Parse(Console.ReadLine()) ;
          
          Console.WriteLine("1.Addition");
          Console.WriteLine("2.Subtraction");
          Console.WriteLine("3.Multiplication");
          Console.WriteLine("4.Division");
          Console.Write("Choose the option above : ");
          int option = int.Parse(Console.ReadLine());
          switch(option)
          {
               case 1:
               {
                    Console.WriteLine(addition(a,b));
                    break;
               }
               case 2:
               {
                    Console.WriteLine(subraction(a,b));
                    break;
               }
               case 3:
               {
                    Console.WriteLine(multiplication(a,b));
                    break;
               }
               case 4:
               {
                    Console.WriteLine(division(a,b));
                    break;
               }
          }
          int addition(int a,int b)
          {
               int c=a+b;
               return c;
          }
          int subraction(int a,int b)
          {
               int c=a-b;
               return c;
          }
          double multiplication(int a,int b)
          {
               double c=(double)a*b;
               return c;
          }
          double division(int a,int b)
          {
               double c=(double) a/b;
               return c;
          }
          Console.Write("If you want to continue give (yes) : ");
          repeat = Console.ReadLine();
          }while(repeat == "yes");
    }
}
