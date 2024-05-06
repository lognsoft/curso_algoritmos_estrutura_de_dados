# Desafio: Cálculo da Média de Raio K

Você recebe um array de inteiros `nums`, indexado a partir de 0 e de tamanho `n`, e um inteiro `k`.

A média de raio `k` para um subarray de `nums` centrado em algum índice `i` com o raio `k` é a média de todos os elementos em `nums` entre os índices `i - k` e `i + k` (inclusive). Se houver menos de `k` elementos antes ou depois do índice `i`, então a média de raio `k` é `-1`.

Construa e retorne um array `avgs` de comprimento `n` onde `avgs[i]` é a média de raio `k` para o subarray centrado no índice `i`.

A média de `x` elementos é a soma dos `x` elementos dividida por `x`, usando divisão inteira. A divisão inteira trunca em direção a zero, o que significa perder a parte fracional.

## Exemplos

### Exemplo 1:

**Entrada:**

```C#
nums = [7, 4, 3, 9, 1, 8, 5, 2, 6], k = 3

//Saida
[-1, -1, -1, 5, 4, 4, -1, -1, -1]
```
**Explicação:**

- `avgs[0]`, `avgs[1]`, e `avgs[2]` são `-1` porque há menos de `k` elementos antes de cada índice.
- A soma do subarray centrado no índice `3` com raio `3` é: `7 + 4 + 3 + 9 + 1 + 8 + 5 = 37`.
- Usando divisão inteira, `avgs[3] = 37 / 7 = 5`.
- Para o subarray centrado no índice `4`, `avgs[4] = (4 + 3 + 9 + 1 + 8 + 5 + 2) / 7 = 4`.
- Para o subarray centrado no índice `5`, `avgs[5] = (3 + 9 + 1 + 8 + 5 + 2 + 6) / 7 = 4`.
- `avgs[6]`, `avgs[7]`, e `avgs[8]` são `-1` porque há menos de `k` elementos após cada índice.