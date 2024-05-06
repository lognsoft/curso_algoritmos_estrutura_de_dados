# Desafio: Cálculo da Média de Raio K

Você recebe um array de inteiros `nums`, indexado a partir de 0 e de tamanho `n`, e um inteiro `k`.

A média de raio `k` para um subarray de `nums` centrado em algum índice `i` com o raio `k` é a média de todos os elementos em `nums` entre os índices `i - k` e `i + k` (inclusive). Se houver menos de `k` elementos antes ou depois do índice `i`, então a média de raio `k` é `-1`.

Construa e retorne um array `avgs` de comprimento `n` onde `avgs[i]` é a média de raio `k` para o subarray centrado no índice `i`.

A média de `x` elementos é a soma dos `x` elementos dividida por `x`, usando divisão inteira. A divisão inteira trunca em direção a zero, o que significa perder a parte fracional.

### Exemplo

**Entrada:**

```C#
nums = [6, 2, 5, 8, 1], k = 2

//Saída
[-1, -1, 4, -1, -1]
```
**Explicação:**

- avgs[0] e avgs[1] são -1 porque há menos de k elementos antes de cada índice.
- A soma do subarray centrado no índice 2 com raio 2 é: 6 + 2 + 5 + 8 + 1 = 22.
- Usando divisão inteira, avgs[2] = 22 / 5 = 4.
- avgs[3] e avgs[4] são -1 porque há menos de k elementos após cada índice.