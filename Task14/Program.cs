namespace Task14;

class Program
{
    static void Main(string[] args)
    {
        int[] massive;
        emptymassive(out massive);
        setmassive(massive);
        outmassive(massive);
    }

    static void emptymassive(out int[] massive)
    { 
        Console.WriteLine("<Введи размерность массива из случайных чисел");
        int a=int.Parse(Console.ReadLine());
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

    static void outmassive(int[] massive)
    {
        Console.WriteLine("Полученный массив: "+string.Join(",",massive));
        /* for (int i = 0; i < massive.Length; i++)
         {
             Console.Write(massive[i]+" ");
         }
         */
    }
}