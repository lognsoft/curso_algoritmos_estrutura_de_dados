int[] nums = new []{3,2,5,6,6};

int t = 2;
int somaAtual = 0;
int maior = 0;

for (int i = 0; i < t; i++)
{
	somaAtual += nums[i];
}

int resposta = somaAtual;

for (int i = t; i < nums.Length; i++)
{
	somaAtual += nums[i] - nums[i - t];

	if (somaAtual > resposta)
	{
		resposta = somaAtual;
	}
	//3,2,5,6,6
}

Console.WriteLine(resposta);


