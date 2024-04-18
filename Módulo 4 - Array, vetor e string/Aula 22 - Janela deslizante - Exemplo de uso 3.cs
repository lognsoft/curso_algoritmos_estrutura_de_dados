int[] nums = new []{7,2,3,9};
int k = 100;

int prod = 0;
int esq = 0;
int multTotal = 1;


for (int dir = 0; dir < nums.Length; dir++)
{
 multTotal *= nums[dir];

 Console.WriteLine(multTotal);
 while (multTotal >= k)
 {
  multTotal /= nums[esq];
  esq++;
 }
 prod += dir - esq + 1;
}

Console.WriteLine(prod);

/*
 Dada uma matriz de inteiros positivos nums um
 inteiro k, retorne o número de submatrizes onde
 o produto de todos os elementos da submatriz é
 estritamente menor que k.

Por exemplo, dada a entrada nums = [7,2,3,9], k = 100

resultado: 9

/*
7 = 7 - ok
7,2 = 14 - ok
7,2,3 = 42 - ok
7,2,3,9 = 378
2 = 2- ok
2,3 = 6- ok
2,3,9 = 54- ok
3 = 3- ok
3,9 = 27- ok
9 = 9- ok
*/

