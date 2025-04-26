namespace Task4;

class Program
{
    
    static void Main()
    {

        try
        {
            Console.WriteLine("Введите размер катета равнобедренного роннепрямоугольного треугольника - ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ для отрисовки треугольника - ");
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine("Отрисовка с левой стороны");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(b);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Отрисовка с правой стороны");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {

                    if (j + i >= a - 1)
                    {
                        Console.Write(b);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
        catch
        {
            Console.WriteLine("Введено неверное значение!");
        }
        
        
    }
}