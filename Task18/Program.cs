namespace Task18;

class Program
{
    
    static void Main(string[] args)
    {
        int a;
        int[] masnegative =new int[] {15,-15,10,-10,-5,-5,0};
        Console.WriteLine(string.Join(" ",masnegative));
        absmass(masnegative, out a);
        Console.WriteLine(string.Join(" ",masnegative)+", количество отрицательных чисел:"+a);
    }

    static void absmass(int[] masnegative, out int a)
    {
        a = 0;
        for (int i = 0; i < masnegative.Length; i++)
        {
            a=(masnegative[i]<0)? ++a: a;
            masnegative[i]=(masnegative[i]<0)? int.Abs(masnegative[i]): masnegative[i];
        }
    }
}