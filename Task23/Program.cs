namespace Task23;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напиши год, укажу високосный он или нет:");
        int year=int.Parse(Console.ReadLine());
           bool isLeap= (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)? true : false;
           if (isLeap)
           {
               Console.WriteLine($"Год {year} - високосный");
           }
           else
           {
               Console.WriteLine($"Год {year} - не високосный");
           } 
        
        
        
    }
}