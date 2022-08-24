Console.WriteLine("Odd numbers Less than 1000:");

for (int g = 1; g < 1000; g++)
{
    if (g % 2 != 0 && g != 999)
    {
        Console.Write(g + ",");
    }
    if (g == 999)
    {
        Console.Write(g + "\n");

    }
}