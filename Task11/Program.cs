namespace Task11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("<Введи размерность массива:");
        int a = int.TryParse(Console.ReadLine(), out a) ? a : 1;
        int[] massive=new int[a];
        setmassive(a, out massive);
        outmassive(a,massive);
    }

    static void setmassive(int a, out int[] massive)
    {
        Console.WriteLine("Вводите по порядку значения для массива:");
        int[] mas = new int[a];
        for (int i = 0; i < a; i++)
        {
            mas[i] = int.TryParse(Console.ReadLine(), out mas[i])? mas[i]: 0;
        }
        massive = mas;
    }


    static void outmassive(int a, int[] massive)
    {
        Console.WriteLine("Полученный массив: "+string.Join(",",massive));
        /* for (int i = 0; i < massive.Length; i++)
         {
             Console.Write(massive[i]+" ");
         }
         */
    }
}