namespace Task21;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("А ну скажи-ка какое число я загадал (от 1 100):");
        Random ran = new Random();
        int num = ran.Next(1,100); 
        int inputnum=int.Parse(Console.ReadLine());
        if (inputnum == num)
        {
            Console.WriteLine("Угадал!!!");
        }
        else
        {
            Console.WriteLine("Мимо( Я загадал "+num);
        }
    }
}