namespace Task3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение a: ");
        float a = int.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.WriteLine("Введите значение b: ");
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение f: ");
            float f = int.Parse(Console.ReadLine());
            float result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine("значение формулы (a+b-f/a)+f*a*a-(a+b)= "+result);
        }
        else
        {
            Console.WriteLine("значение а не может быть равно 0");
        }
        
    }
}