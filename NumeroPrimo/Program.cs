int num = 0, contador = 1;
Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());
if (num > 1)
{
    for (int i = num; i > 1; i--)
    {
        if (num % i == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        Console.WriteLine("O número é primo!");
    }
    else
    {
        Console.WriteLine("O número não é primo!");
    }
}
else
{
    Console.WriteLine("O número deve ser maior que 1");
}
            