using System;

// Algoritmo SelectionSort, não é o código da aula,
// mas é um código mais interessante e útil
// para que você veja uma real utilidade do O(n^2).

public static void Sort(int[] arr)
{
    int n = arr.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        // Troca o elemento mínimo encontrado com o elemento na posição 'i'
        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
}

int[] arr = { 64, 25, 12, 22, 11 };
int n = arr.Length;

Console.WriteLine("Array desordenado:");
for (int i = 0; i < n; i++)
    Console.Write(arr[i] + " ");
Console.WriteLine();

SelectionSort.Sort(arr);

Console.WriteLine("Array ordenado:");
for (int i = 0; i < n; i++)
    Console.Write(arr[i] + " ");
Console.WriteLine();