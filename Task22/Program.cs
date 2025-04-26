namespace Task22;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("А ну скажи-ка какое число я загадал (от 1 100):");
        Random ran = new Random();
        int num = ran.Next(1,100);
        int score = 1;
        do
        {
            int inputnum=int.Parse(Console.ReadLine());
            if (inputnum == num)
            {
                Console.WriteLine($"Ну наконец-то!!! Угадал с {score} попытки.");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Мимо(");
                score++;
            }  
        }while (score < 100);
        
        
    }
}