namespace Task19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("<Введи размерность массива из случайных чисел");
        int a=int.Parse(Console.ReadLine());
        int[] massive=new int[a];
        int max, min;
        setmassive(a, out massive);
        maxminmas(massive, out max, out min);
        outmassive(a,massive);
        Console.WriteLine("Максимальне число массива:"+max);
        Console.WriteLine("Минимальное число массива:"+min);
    }

    static void maxminmas(int[] massive, out int max, out int min)
    {
        max = massive.Max();
        min = massive.Min();
    }
    static void setmassive(int a, out int[] massive)
    {
        Random ran = new Random();
        int[] mas = new int[a];
        for (int i = 0; i < a; i++)
        {
            mas[i] = ran.Next(a);
        }
        massive = mas;
    }


    static void outmassive(int a, int[] massive)
    {
        Console.WriteLine(string.Join(",",massive));
        /* for (int i = 0; i < massive.Length; i++)
         {
             Console.Write(massive[i]+" ");
         }
         */
    }
}