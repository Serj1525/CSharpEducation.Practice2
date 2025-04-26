namespace Task25;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Наши номер дня недели:");
        int inputday = int.Parse(Console.ReadLine());
        Console.WriteLine("Ну дык это "+(DayOfWeek)((inputday-1) % Enum.GetValues(typeof(DayOfWeek)).Length));
           
    }

    public enum DayOfWeek
    {
        понедельник = 0,
        вторник = 1,
        среда = 2,
        четверг = 3,
        пятница = 4,
        суббота = 5,
        воскресенье = 6
    }
}