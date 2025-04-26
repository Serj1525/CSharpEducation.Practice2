namespace Task6;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите чё-нить - ");
        string input=Console.ReadLine();
        char[] sentence=input.ToCharArray();
        Console.Write("Введите символ какой-нить - ");
        char symbol=char.Parse(Console.ReadLine());
        int i = 0;
        foreach (char c in sentence)
        {
            i= c==symbol? ++i : i;
        }
        float percent = i*100 / (sentence.Length);
        Console.WriteLine(" Частота появления символа "+symbol+" во фразе равна "+percent+"%.");
    }
}