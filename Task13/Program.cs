namespace Task13;

class Program
{
    static void Main()
    {
        Console.Write("<Введи количество строк массива:");
        int a = int.TryParse(Console.ReadLine(), out a) ? a : 1;
        Console.Write("<Введи количество столбцов массива:");
        int b = int.TryParse(Console.ReadLine(), out a) ? a : 1;
        
        int[,] massive=new int[a,b];
        setmassive(a,b, out massive);
        outmassive(a,b, massive);
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
        //Console.WriteLine("Полученный массив: "+string.Join(",",massive));
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