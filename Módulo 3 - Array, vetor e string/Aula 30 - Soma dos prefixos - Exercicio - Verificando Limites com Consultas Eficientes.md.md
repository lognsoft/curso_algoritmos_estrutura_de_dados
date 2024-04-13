# Desafio de Programação: Soma de Subarrays

## Objetivo

Desenvolver um programa que analise um array de inteiros e determine se a soma de subconjuntos específicos desses inteiros está dentro de um limite pré-definido.

## Dados de Entrada

- **Array de Inteiros (`nums`)**: Um array de números inteiros. Por exemplo, `[4, 8, 5, 9, 1, 3]`.
- **Consultas (`queries`)**: Uma matriz de consultas onde cada consulta é um par `[x, y]`. Esses pares representam os índices inicial e final dos subconjuntos do array `nums` cuja soma precisa ser calculada.
- **Limite (`limit`)**: Um número inteiro que serve como o limite máximo para as somas dos subarrays. Por exemplo, `13`.

## Processo

1. **Inicialização do Array de Prefixos**: 
   - Calcula um array de prefixos que contém a soma cumulativa dos elementos do array `nums` até cada posição. Isso facilita o cálculo rápido das somas dos subarrays.

2. **Cálculo das Soma dos Subarrays**:
   - Para cada consulta `[x, y]`, a soma do subarray correspondente é calculada usando o array de prefixos.

3. **Comparação com o Limite**:
   - Cada soma calculada é comparada com o `limit`. Se a soma for menor que o limite, o resultado é `true` (verdadeiro). Se for igual ou maior, o resultado é `false` (falso).

## Resultados

- Retorna uma lista de valores booleanos (`true` ou `false`) representando se a soma de cada subarray especificado nas consultas está ou não dentro do limite estabelecido.

## Exemplo de Implementação em C#

```csharp
/*int[] nums = new int[]{ 4, 8, 5, 9, 1, 3 };
int[] prefix = new int[nums.Length];
int[,] queriesArray = new int[,]
{
    { 0, 2 }, 
    { 1, 4 }, 
    { 3, 5 }
};
bool[] resultBools = new bool[queriesArray.GetLength(0)];
int target = 13;

// Construção do array de prefixos
prefix[0] = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    prefix[i] = nums[i] + prefix[i - 1];
}

// Processamento de cada consulta
for (int i = 0; i < queriesArray.GetLength(0); i++)
{
    int inicio = queriesArray[i, 0];
    int fim = queriesArray[i, 1];
    int res = inicio == 0 ? prefix[fim] : prefix[fim] - prefix[inicio - 1];
    resultBools[i] = res < target;
}

// Exibição dos resultados
for (int i = 0; i < resultBools.Length; i++)
{
    Console.WriteLine(resultBools[i]);
}*/
