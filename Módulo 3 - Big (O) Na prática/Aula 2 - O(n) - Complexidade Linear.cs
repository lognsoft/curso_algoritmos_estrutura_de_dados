using System;

// Algoritmo LinearSearch, não é o código da aula,
// mas é um código mais interessante e útil
// para que você veja uma real utilidade do O(n).
public static int Search(int[] arr, int target)
{
	int n = arr.Length;

	for (int i = 0; i < n; i++)
	{
		if (arr[i] == target)
		{
			return i; // Elemento encontrado, retornamos o índice
		}
	}
	return -1; // Elemento não encontrado
}

int[] arr = { 12, 35, 45, 10, 55, 23, 50 };
int target = 55;

int result = Search(arr, target);

if (result != -1)
{
	Console.WriteLine("Elemento encontrado na posição: " + result);
}
else
{
	Console.WriteLine("Elemento não encontrado no array.");
}