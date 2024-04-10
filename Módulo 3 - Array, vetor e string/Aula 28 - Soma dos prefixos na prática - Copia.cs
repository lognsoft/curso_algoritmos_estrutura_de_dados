int[] nums = new int[] { 3, 2, 4, 5, 5 };
int[] prefixo = new int[nums.Length];

prefixo[0] = nums[0];

for (int i = 1; i < prefixo.Length; i++)
{
    prefixo[i] = nums[i] + prefixo[i - 1];
}

int inicio = 0;
int fim = 4;

int resultado;

if (inicio == 0)
{
    resultado = prefixo[fim];
}
else
{
    resultado = prefixo[fim] - prefixo[inicio - 1];
}

Console.WriteLine(resultado);
