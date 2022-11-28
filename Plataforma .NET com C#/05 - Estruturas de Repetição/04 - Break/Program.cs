int numero = 5;

for (int index = 0; index <= 100; index++)
{
    Console.WriteLine($"{numero * index}");

    if (index == 5)
    {
        break;
    }
}