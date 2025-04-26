    using System.Diagnostics.CodeAnalysis;

    int i = 0;
    
    Console.WriteLine("Вывод значения со счетчика:");
    for (i = 0; i < 10; i++)
    {
        Console.Write(i + " ");
    }
    
    Console.WriteLine($"");
    Console.WriteLine($"Вывод значения из цикла с предусловием:");
    i = 0;
    while ( i<10)
    {
        Console.Write(i + " ");
        i++;
    }
    
    Console.WriteLine($"");
    Console.WriteLine($"Вывод значения из цикла c постусловием:");
    i = 0;
    do
    {
        Console.Write(i + " ");
        i++;
    } while (i < 10);
    
    Console.WriteLine($"");
    Console.WriteLine($"Вывод мудрой фразы с циклом:");
    string[] sentence = {"программа", "велит", "тебе", "говорить", "странно"};
    
    int[] perm = {0,1,2,3,4};
    Random r = new Random();
    for (i = 4; i >= 1; i--)
    {
        int j = r.Next(i + 1);
        int temp = perm[j];
        perm[j] = perm[i];
        perm[i] = temp;
    }
    for (i = 0; i <5; i++)
    {
        Console.Write(sentence[perm[i]] + " ");  
    }
    
    Console.WriteLine($"");
    Console.WriteLine($"Вывод фразы по словам, введенным в консоль:");
    i = 0;
    string word;
    while ( i<5)
    {
        word = Convert.ToString(Console.ReadLine());
        sentence[i] = word;
        i++;
    }

    foreach (string cell in sentence)
    {
        Console.Write(cell+ " ");
    }
 
    Console.WriteLine($"");
    Console.WriteLine($"То же самое, но для цикла с постусловием :");
    i = 0;
    do
    {
        word = Convert.ToString(Console.ReadLine());
        sentence[i] = word;
        i++;
    } while (i < 5);

    foreach (string cell in sentence)
    {
        Console.Write(cell+ " ");
    }
