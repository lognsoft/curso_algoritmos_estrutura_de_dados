/*
Desafio: Encontrar a Subsequência Mínima

Você recebe um array nums contendo inteiros positivos e um inteiro positivo target.
Sua tarefa é determinar o comprimento da menor subsequência contínua dentro de nums cuja soma dos elementos
seja igual ou superior a target.

Resultado:

Se tal subsequência existir, retorne o comprimento mínimo dessa subsequência.
Caso contrário, se não for possível encontrar uma subsequência que satisfaça a condição de soma maior ou igual a target, retorne 0.
Exemplo:

Se nums = [1, 2, 3, 4, 5] e target = 11, a menor subsequência que soma 11 ou mais é [3, 4, 5],
cujo comprimento é 3. Portanto, a resposta seria 3.
*/

int[] nums = new[] {1,1,1,5,1,1,1,1,1,1,1 };
int target = 11;
int esq = 0;
int somaTotal = 0;
int resultado = int.MaxValue;

//Console.WriteLine(resultado);

for (int dir = 0; dir < nums.Length; dir++)
{
	somaTotal += nums[dir];

	while (somaTotal >= target)
	{
		int pos = dir - esq + 1;

		if (pos <= resultado)
		{
			resultado = pos;
		}
		
		//Console.WriteLine($"{esq} - {dir} - {pos} - {somaTotal}");
		
		somaTotal -= nums[esq];
		esq++;
	}
}

if (resultado == int.MaxValue)
{
	resultado = 0;
}

Console.WriteLine(resultado);

















