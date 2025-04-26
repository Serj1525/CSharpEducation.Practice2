namespace Task12;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("<Введи размерность массива:");
        int a = int.TryParse(Console.ReadLine(), out a) ? a : 1;
        string[] massive=new string[a];
        setmassive(a, out massive);
        outmassive(a,massive);
    }

    static void setmassive(int a, out string[] massive)
    {
        Console.WriteLine("Вводите по порядку значения для массива:");
        string [] mas = new string[a];
        for (int i = 0; i < a; i++)
        {
            mas[i] = Console.ReadLine();
        }
        massive = mas;
    }


    static void outmassive(int a, string[] massive)
    {
        Console.WriteLine("Полученный массив: "+string.Join(",",massive));
        /* for (int i = 0; i < massive.Length; i++)
         {
             Console.Write(massive[i]+" ");
         }
         */
    }
}