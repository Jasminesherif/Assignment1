using System;
using System.Threading;

public class BasicApp
{
    enum UserRole
    {
        Admin, 
        Manager, 
        Employee
    };
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name, age and favourite programming lamguage respectively");
        string Name = Console.ReadLine();
        string Language = Console.ReadLine();
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello, {Name}! You're {Age} and love {Language}!\n");
        do
        {
            bool flag = false;
            Console.WriteLine("Enter a number  from 0 to 2 based on your role");
            UserRole userrole = Console.ReadLine();
            switch (userole)
            {
                case 0:
                    userrole = UserRole.Admin;
                    Console.WriteLine($"{UserRole.ToStrinng()}: You have full access");
                    break;
                case 1:
                    userrole = UserRole.Manager;
                    Console.ReadLine(UserRole.ToString() + ": You manage teams");
                    break;
                case 2:
                    userrole = UserRole.Employee
                    Console.ReadLine($"{UserRole.ToString()}: You have limited access");
                    break;
                default:
                    Console.ReadLine("Invalid choice, try again");
                    flag = true;
                    break;
            }
        }while (flag) ;


        int hours, avghours=0, totalhours=0;
        Console.WriteLine("Enter how many working hours you have worked this week for each day");
        for(int i=0; i<7; i++)
        {
            hours = Console.ReadLine();
            while (hours < 0)
            Console.WriteLine("Invalid entery, please re-enter your working hours for today");
            totalhours += totalhours;
            avghours = totalhours / hours;
        }
        Console.WriteLine("Total hours worked this week: " + hours);
        Console.WriteLine("Average hours/day: " + avghours);

        string[] process = new[] { "Check-In", "Meeting", "Coding", "Break", "Submit Report" };
        for(int i=0; i<5; i++)
        {
            Thread.Sleep((500));
            Console.WriteLine(process);
        }
    }
}