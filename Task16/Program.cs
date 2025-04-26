namespace Task16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int a=int.Parse(Console.ReadLine());
        invertnum(ref a);
        Console.WriteLine(a);
        
    }

    static void invertnum(ref int a)
    {
        a = -a;
    }
}