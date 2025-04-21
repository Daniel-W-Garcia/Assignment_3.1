namespace Assignment_3._1;

public class LeapYear
{
    public bool isLeapYear;
    
    public bool IfYearIsLeap(int year)
    {
        isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        return isLeapYear;
    }

    public void TestLeapYear()
    {
        Console.Write("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());
        
        IfYearIsLeap(year);

        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year");
        }
    }
}