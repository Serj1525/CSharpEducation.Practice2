namespace Task17;

class Program
{
    static void Main(string[] args)
    {
        invertnums();
    }

    static void invertnums()
    {
        Console.WriteLine("введите 1 число:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("введите 1 число:");
        int b=int.Parse(Console.ReadLine());
        Console.WriteLine("Числа в обратном порядке: "+b+" "+a);
    }
}