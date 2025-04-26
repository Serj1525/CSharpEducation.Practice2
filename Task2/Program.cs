namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        float distance;
        

        try
        {
            Console.Write("Введите дистанцию в метрах: ");
            distance = float.Parse(Console.ReadLine());
            Console.Write("Введите время прохождения дистанции в секундах: ");
            float time = float.Parse(Console.ReadLine());
            Console.Write("Введите температуру в градусах Цельсия: ");
            float temperatureinC = float.Parse(Console.ReadLine());

            float distanceinkm = distance / 1000;
            float distanceincm = distance*100;
            float speedmkminh = (distance/time)*3600/1000;
            float temperatureinF = (temperatureinC*9/5)+32;
            Console.WriteLine("Дистанция = "+distanceinkm+"км, или " + distanceincm + "см.");
            Console.WriteLine("Скорость = "+speedmkminh+"км/ч.");
            Console.WriteLine("Температура = "+temperatureinF+"гр.F.");
        }
        catch
        {
            Console.WriteLine("Введите число, а не вот это вот всё");
        }

    }
}