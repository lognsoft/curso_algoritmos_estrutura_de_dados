using System;

public static int Search(int[] arr, int target)
{
	int left = 0;
	int right = arr.Length - 1;

	while (left <= right)
	{
		int mid = left + (right - left) / 2;

		if (arr[mid] == target)
		{
			return mid; // O elemento foi encontrado
		}
		else if (arr[mid] < target)
		{
			left = mid + 1; // O elemento está à direita do meio
		}
		else
		{
			right = mid - 1; // O elemento está à esquerda do meio
		}
	}

	return -1; // O elemento não foi encontrado no array
}

int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
int target = 12;

int result = Search(arr, target);

if (result != -1)
{
	Console.WriteLine("Elemento encontrado na posição: " + result);
}
else
{
	Console.WriteLine("Elemento não encontrado no array.");
}