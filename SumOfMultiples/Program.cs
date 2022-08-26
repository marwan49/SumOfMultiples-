/*
 * Crie uma aplicação Console que some os números naturais múltiplos de 3 e 5 de uma sequência, 
 * seguindo as regras abaixo:
- A aplicação deve solicitar um número ao usuário.
- Em seguida a aplicação irá somar todos os números naturais de 0 até o número informado 
  que sejam múltiplos de 3 ou 5.
- No final, deverá ser exibida a soma desses números ao usuário.
*/

int maxNumber;

List<int> sum = new List<int>();

int total = 0;

Console.WriteLine("digite um numero:");

maxNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= maxNumber; i++)
{
    if(i % 3 == 0 || i % 5 == 0)
    {
        sum.Add(i);
        total = total + i;
    }
}

Console.WriteLine("A soma de 0 a {0} é = ", maxNumber);

sum.ForEach(x =>
{
    if (x != sum.Last())
        Console.Write(x + " + ");
    else
        Console.Write(x);
});

Console.Write(" = " + total);
