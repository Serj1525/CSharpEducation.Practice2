namespace Task15;

class Program
{
    static void Main(string[] args)
    {
        int[] massive;
        emptymassive(out massive);
        setmassive(massive);
        outmassive(massive);
        invertmassive(massive);
        outmassive(massive);
    }

    static void emptymassive(out int[] massive)
    {
        Console.WriteLine("<Введи размерность массива из случайных чисел");
        int a = int.Parse(Console.ReadLine());
        massive = new int[a];
    }

    static void setmassive(int[] massive)
    {
        Random ran = new Random();
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = ran.Next(massive.Length);
        }
    }

    static void invertmassive(int[] massive)
    {
        int temp;
        for (int i = 0; i < massive.Length/2; i++)
        {
            temp = massive[i];
            massive[i] = massive[massive.Length-1 - i];
            massive[massive.Length-1 - i]=temp;
        }
        Console.WriteLine("Идет инвертирование массива.");
    }

    static void outmassive(int[] massive)
    {
        Console.WriteLine("Полученный массив: " + string.Join(",", massive));
    }
}