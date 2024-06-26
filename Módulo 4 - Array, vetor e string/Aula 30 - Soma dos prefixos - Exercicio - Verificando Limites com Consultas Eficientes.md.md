# Desafio de Programação: Verificando Limites com Consultas Eficientes

## Objetivo

Desenvolver um programa que analise um array de inteiros e determine se a soma de subconjuntos específicos desses inteiros está dentro de um limite pré-definido.

## Dados de Entrada

- **Array de Inteiros (`nums`)**: Um array de números inteiros. Por exemplo, `[4, 8, 5, 9, 1, 3]`.
- **Consultas (`queries`)**: Uma matriz de consultas onde cada consulta é representada por um par `[x, y]`. Estes pares indicam os índices inicial e final de subconjuntos do array `nums` cuja soma precisa ser calculada. A matriz é definida como:
  ```plaintext
  [[0, 2],
   [1, 4],
   [3, 5]]
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
int[] nums = new int[]{4,8,5,9,1,3};

int[] prefixo = new int[nums.Length];

int limit = 15;

int[,] queriesArray = new int[,]
{
    { 0, 2 },
    { 1, 4 },
    { 3, 5 }
};

bool[] resBools = new bool[queriesArray.GetLength(0)];

prefixo[0] = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    prefixo[i] = nums[i] + prefixo[i - 1];
}


//Console.WriteLine(queriesArray.GetLength(0));

for (int i = 0; i < queriesArray.GetLength(0); i++)
{
    int inicio = queriesArray[i, 0];
    int fim = queriesArray[i, 1];

    int res = 0;

    if (inicio == 0)
    {
        res = prefixo[fim];
    }
    else
    {
        res = prefixo[fim] - prefixo[inicio - 1];
    }

    resBools[i] = res < limit;

    Console.WriteLine(res);
}

for (int i = 0; i < resBools.Length; i++)
{
    Console.WriteLine(resBools[i]);
}
