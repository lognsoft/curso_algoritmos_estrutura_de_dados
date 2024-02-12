using System;

// Algoritmo FindElement, não é o código da aula,
// mas é um código mais interessante e útil
// para que você veja uma real utilidade do O(1).
public static int FindElement(int[] arr, int index)
{
	if (index >= 0 && index < arr.Length)
	{
		return arr[index]; // Retorna o elemento no índice especificado
	}
	else
	{
		return -1; // Índice fora do intervalo, elemento não encontrado
	}
}

public static void Main()
{
	int[] arr = { 10, 20, 30, 40, 50 };

	int indexToFind = 2;
	int element = FindElement(arr, indexToFind);

	if (element != -1)
	{
		Console.WriteLine("Elemento encontrado: " + element);
	}
	else
	{
		Console.WriteLine("Índice fora do intervalo, elemento não encontrado.");
	}
}