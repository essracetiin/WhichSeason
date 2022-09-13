// See https://aka.ms/new-console-template for more information

Hangi();

void Hangi()
{
    try
    {
        Console.WriteLine("Hangi yarımküredesiniz?");
        string ?yk = Console.ReadLine();

        Console.WriteLine("Kaçıncı aydasınız?");
        int ay = Convert.ToInt32(Console.ReadLine());

        if (yk == "k" && (ay == 12 || ay == 1 || ay == 2))
        {
            Console.WriteLine("Kış mevsimindesiniz.");
        }
        else if (yk == "k" && (ay == 3 || ay == 4 || ay == 5))
        {
            Console.WriteLine("İlkbahar mevsimindesiniz.");
        }
        else if (yk == "k" && (ay == 6 || ay == 7 || ay == 8))
        {
            Console.WriteLine("Yaz mevsimindesiniz.");
        }
        else if (yk == "k" && (ay == 9 || ay == 10 || ay == 11))
        {
            Console.WriteLine("Sonbahar mevsimindesiniz.");
        }
        else if (yk == "g" && (ay == 12 || ay == 1 || ay == 2))
        {
            Console.WriteLine("Yaz mevsimindesiniz.");
        }
        else if (yk == "g" && (ay == 3 || ay == 4 || ay == 5))
        {
            Console.WriteLine("Sonbahar mevsimindesiniz.");
        }
        else if (yk == "g" && (ay == 6 || ay == 7 || ay == 8))
        {
            Console.WriteLine("Kış mevsimindesiniz.");
        }
        else if (yk == "g" && (ay == 9 || ay == 10 || ay == 11))
        {
            Console.WriteLine("İlkbahar mevsimindesiniz.");
        }
        else
        {
            Console.WriteLine("Yanlış karakter girdiniz!");
        }
        Console.ReadLine();
        Hangi();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Hangi();
    }
    
}

