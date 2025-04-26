namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введи первое число - ");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Введи второе число - ");
        int b=int.Parse(Console.ReadLine());
        Console.WriteLine("Введи третье число - ");
        int c=int.Parse(Console.ReadLine());
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("a="+(a+5)+",b="+(b+5)+",c="+(c+5));
            }
            else
            {
                Console.WriteLine("равных 2 чисел нет");
            }
    }
}