int numero, fatorial = 1;
// n X 1 = proprio n, se a entrada do usuário for 1, o fatorial desse número será 1.
// Se a entrada do usuário for 2, o fatorial será 2 x 1 = 2. Se a entrada do usuário
// for 3, o fatorial será 3 x 2 x 1 = 6 e assim vai.
while (true)
{
    //laço repetindo até que o valor possa ser convertido para int.
    Console.Write("Digite o numero para ser calculado o fatorial: ");

    if (!int.TryParse(Console.ReadLine(), out numero) || numero > 12)
    {
        Console.WriteLine("O calculo fatorial pode ser impreciso com esse valor. Por favor, digite um número válido! (1 - 12)");
    }
    else
        break;
}
for (int i = 1; i <= numero; i++) fatorial *= i; // fat = fat * i
Console.WriteLine("{0}! dá {1}", numero, fatorial);
