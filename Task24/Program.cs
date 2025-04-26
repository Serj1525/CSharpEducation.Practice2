namespace Task24;

class Program
{
    static void Main(string[] args)
    {
        foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
        {
            Console.WriteLine(day.ToString()); 
        }
    }

    public enum DayOfWeek
    {
        понедельник,
        вторник,
        среда,
        четверг,
        пятница,
        суббота,
        воскресенье


    };
}



