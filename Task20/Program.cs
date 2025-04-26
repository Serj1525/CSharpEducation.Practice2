namespace Task20;

class Program
{
    static void Main()
    {
        Console.Write("<Введи количество строк массива:");
        int a = int.TryParse(Console.ReadLine(), out a) ? a : 1;
        Console.Write("<Введи количество столбцов массива:");
        int b = int.TryParse(Console.ReadLine(), out b) ? b : 1;
        
        int[,] massive=new int[a,b];
        int[,] maxminmassive=new int[a,2];
        setmassive(a,b, out massive);
        outmassive(a,b, massive);
        setmaxminmas(massive,a, b, out maxminmassive);
        outmassive(a,2, maxminmassive);
        
    }

    static void setmaxminmas(int[,] massive, int a, int b, out int[,] maxminmassive)
    {
        int[,] maxminmas = new int[a,2];
        int max = 10, min = 0;
        Console.WriteLine("Вывод максимума и минимума массива построчно:");
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                maxminmas[i,0] = (j==0 || max<massive[i,j])? max=massive[i,j]:max;
                maxminmas[i,1] = (j==0 || min>massive[i,j])? min=massive[i,j]:min;
            }
        }
        maxminmassive=maxminmas;
    }

    static void setmassive(int a, int b, out int[,] massive)
    {
        Random ran = new Random();
        int[,] mas = new int[a,b];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                mas[i,j] = ran.Next(10); 
            }
        }
        massive = mas;
    }


    static void outmassive(int a, int b, int[,] massive)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(massive[i,j]+", ");
            }
            Console.WriteLine("");
        }
         
    }
}