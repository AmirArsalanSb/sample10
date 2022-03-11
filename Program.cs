for (int i = 0; i < 4; i++)
{
    for (int x = 4; x > i+1 ; x--)
    {
        Console.Write(" ");
    }
    for (int y = 0; y <=i*2; y++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}