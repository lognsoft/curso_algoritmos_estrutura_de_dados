string binario = "111001100101";

int resultado = maiorSequencia();

Console.WriteLine(resultado);

int maiorSequencia()
{
	int esq = 0;
	int res = 0;
	int z = 0;

	for (int dir = 0; dir < binario.Length; dir++)
	{
		if (binario[dir] == '0')
		{
			z++;
		}

		while (z > 1)
		{
			if (binario[esq] == '0')
			{
				z--;
			}
			esq++;
		}

		int x = dir - esq + 1;
		
		res = res < x ? x : res;

	}
	
	return res;
}