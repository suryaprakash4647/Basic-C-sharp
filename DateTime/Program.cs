using System;
namespace DateTimee;
public class Program
{
    public static void Main(string[] args)
    {
        // DateTime date = new DateTime(2021,8,10,10,40,32);
        // // date.ToString("dd/MM/yyyy hh:mm:ss tt");
        // Console.WriteLine("Date    :"+date.Day);
        // Console.WriteLine("Month   :"+date.Month);
        // Console.WriteLine("Year    :"+date.Year);
        // Console.WriteLine("Year    :"+date.Hour);
        // Console.WriteLine("Minutes :"+date.Minute);
        // Console.WriteLine("Seconds :"+date.Second);
        // string s=date.ToString("dd/MM/yyyy hh:mm:ss tt");
        // string[] sArray = s.Split('/',' ',':');
        // Console.WriteLine("----- Reverse Order -----");
        // Console.WriteLine("Output : ");
        // for(int i=sArray.Length-1;i>=0;i--)
        // {
        //     Console.Write(sArray[i]+" ");
        // }
        // Console.WriteLine("");
        // Console.Write("Enter the DateTime in string Formet (yyyy/MM/dd hh:mm:ss tt) : ");
        // String str = Console.ReadLine();
        // string[] strArray = str.Split('/',' ',':');
        // Console.WriteLine("Year  : "+strArray[0]);
        // Console.WriteLine("Month : "+strArray[1]);
        // Console.WriteLine("Day   : "+strArray[2]);
        
        // DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        // DateTime today=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        // TimeSpan diff=TimeSpan(dob-today);
        // Console.WriteLine("Hello World");
        
        // string s=Console.ReadLine();
        // string res="";
        // foreach(char c in s)
        // {
        //     if(!res.Contains(c))
        //     {
        //         res=res+c;
        //     }
        // }
        // Console.WriteLine(res);



        // string s1=Console.ReadLine();
        // string s2=Console.ReadLine();
        // char[] c1=s1.ToCharArray();
        // char[] c2=s2.ToCharArray();
        // for(int i=0;i<c1.Length;i++)
        // {
        //     for(int j=0;j<c1.Length;j++)
        //     {
        //         if(c1[i]<c1[j]&& i!=j)
        //         {
        //             char temp=c1[i];
        //             c1[i]=c1[j];
        //             c1[j]=temp;
        //         }
        //     }
        // }
        // for(int i=0;i<c2.Length;i++)
        // {
        //     for(int j=0;j<c2.Length;j++)
        //     {
        //         if(c2[i]<c2[j]&& i!=j)
        //         {
        //             char temp=c2[i];
        //             c2[i]=c2[j];
        //             c2[j]=temp;
        //         }
        //     }
        // }
        // string result1=string.Join("",c1);
        // string result2=string.Join("",c2);
        // if(result1==result2)
        // {
        //     Console.WriteLine("Anagram");
        // }
        // else
        // {
        //     Console.WriteLine("not Anagram");
        // }
        
        DateTime d1=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        TimeSpan d=d1-dob;
        double age=d.TotalDays;
        Console.WriteLine("Age : "+(int)age/365);
        Console.WriteLine("Day : "+dob.DayOfWeek);
        Console.WriteLine("Number of days : "+d.Days);
        Console.WriteLine("Number of hours : "+d.TotalHours);
        Console.WriteLine("Number of minutes : "+d.TotalMinutes);
    }
}
