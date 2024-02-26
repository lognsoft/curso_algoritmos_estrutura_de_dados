int[] vet1 = new []{1,3,7,32,55,667,7777};
int[] vet2 = new int[]{1,2,2,9};

int[] novoVetor = new int[vet1.Length + vet2.Length];

int c1 = 0;
int c2 = 0;
int count = 0;

while (c1 < vet1.Length && c2 < vet2.Length)
{
	if (vet1[c1] < vet2[c2])
	{
		novoVetor[count] = vet1[c1];
		c1++;
	}
	else
	{
		novoVetor[count] = vet2[c2];
		c2++;
	}

	count++;
}

while (c1 < vet1.Length)
{
	novoVetor[count] = vet1[c1];
	c1++;
	count++;
}

while (c2 < vet2.Length)
{
	novoVetor[count] = vet2[c2];
	c2++;
	count++;
}

for (int i = 0; i < novoVetor.Length; i++)
{
	Console.WriteLine(novoVetor[i]);
}