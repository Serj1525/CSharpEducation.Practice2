namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 1-е число - ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите 2-е число - ");
        int b = int.Parse(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine("Значение a>b");
        }
        else if(a<b)
        {
            Console.WriteLine("Значение a<b");
        }
        else
        {
            Console.WriteLine("Значение a=b");
        }
    }
}