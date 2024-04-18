/*Dado um array de inteiros nums com n elementos e um inteiro k,
 encontre uma subarray contígua de comprimento k que tenha o maior valor médio. 
 Retorne esse valor.

Exemplo:
Dado o array de inteiros nums = [1, 12, -5, -6, 50, 3] e k = 4,
a subarray contígua com maior valor médio é [12, -5, -6, 50].
A média dessa subarray é (12 - 5 - 6 + 50) / 4 = 12.75.
Portanto, o resultado seria 12.75.
*/

int[] nums = new []{1,100,100, 12, -5, -6, 50, 3,50};
int k = 4;
double totalAtual = 0;

for (int i = 0; i < k; i++)
{
 totalAtual += nums[i];
}
double resultado = totalAtual / k;

Console.WriteLine(resultado);

for (int i = k; i < nums.Length; i++)
{
 totalAtual += nums[i] - nums[i - k];

 double media = totalAtual / k;
 
 Console.WriteLine(media);

 if (media > resultado)
 {
  resultado = media;
 }
}
Console.WriteLine("res final" + resultado);













