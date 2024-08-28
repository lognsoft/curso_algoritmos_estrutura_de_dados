# Desafio: Cálculo da Média de Raio K

Você recebe um array de inteiros `nums`, indexado a partir de 0 e de tamanho `n`, e um inteiro `k`.

A média de raio `k` para um subarray de `nums` centrado em algum índice `i` com o raio `k` é a média de todos os elementos em `nums` entre os índices `i - k` e `i + k` (inclusive). Se houver menos de `k` elementos antes ou depois do índice `i`, então a média de raio `k` é `-1`.

Construa e retorne um array `medias` de comprimento `n` onde `medias[i]` é a média de raio `k` para o subarray centrado no índice `i`.

A média de `x` elementos é a soma dos `x` elementos dividida por `x`, usando divisão inteira. A divisão inteira trunca em direção a zero, o que significa perder a parte fracional.

### Exemplo

**Entrada:**

```C#
nums = [6, 2, 5, 8, 1], k = 1

//Saída
[-1, 4,33, 5, 4,66, -1]
```
**Explicação:**

- **`medias[0]` e `medias[4]` são `-1`** porque há menos de `k` elementos antes ou após cada índice respectivamente.
- A soma do subarray centrado no índice `1` com raio `1` é: `6 + 2 + 5 = 13`.
- Usando divisão inteira, **`medias[1] = 13 / 3 = 4,33`**.
- A soma do subarray centrado no índice `2` com raio `1` é: `2 + 5 + 8 = 15`.
- Usando divisão inteira, **`medias[2] = 15 / 3 = 5`**.
- A soma do subarray centrado no índice `3` com raio `1` é: `5 + 8 + 1 = 14`.
- Usando divisão inteira, **`medias[3] = 14 / 3 = 4,66`**.

### Solução
```C#

int[] nums = new int[] { 6, 2, 5, 8, 1 };
int k = 1; // Define o alcance de k elementos à esquerda e à direita para a média

// Cria o array de soma dos prefixos
int[] prefix = new int[nums.Length];
prefix[0] = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    prefix[i] = prefix[i - 1] + nums[i];
}

// Array para armazenar as médias dos subarrays
int[] medias = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    int left = i - k;
    int right = i + k;

    if (left < 0 || right >= nums.Length)
    {
        // Se não existem elementos suficientes antes ou depois, a média é -1
        medias[i] = -1;
    }
    else
    {
        // Calcula a soma do subarray usando a soma dos prefixos
        int soma = prefix[right] - (left > 0 ? prefix[left - 1] : 0);
        // Calcula a média usando divisão inteira
        medias[i] = soma / (2 * k + 1);
    }
}

// Impressão das médias calculadas
Console.WriteLine(string.Join(", ", medias));
