# Desafio: Balanceamento de Portfólio

## Visão Geral

Neste desafio, você, como analista financeiro, precisa avaliar como um portfólio de investimentos pode ser dividido em duas seções, de forma que a soma dos retornos percentuais dos ativos na primeira seção seja maior que na segunda. O objetivo é determinar quantas maneiras existem de fazer essa divisão, considerando que a segunda seção deve sempre conter pelo menos um ativo para garantir diversificação.

## Objetivo

Descobrir quantas divisões do array `nums`, que representa retornos de ativos em percentuais, satisfazem a condição de que a soma dos retornos na primeira parte seja maior que na segunda.

## Entradas

- Um array de inteiros `nums`, onde cada elemento representa o retorno percentual esperado de um ativo individual no portfólio.

## Saída Esperada

- Um inteiro representando o número total de divisões possíveis que satisfazem a condição do desafio.

## Exemplo de Entrada e Saída

### Entrada

```plaintext
portifolio = [3, 4, 6, 2, 7]
```

## Explicação Detalhada

Vamos analisar o novo vetor de entrada `[3, 4, 6, 2, 7]`. Nosso objetivo é determinar em quantos pontos de divisão a soma dos elementos na primeira parte é maior que na segunda, seguindo a regra de que a segunda parte deve conter pelo menos um elemento.

### Análise das Possíveis Divisões

1. **Divisão após o primeiro elemento `[3]`:**
   - **Primeira parte:** `[3]`
   - **Segunda parte:** `[4, 6, 2, 7]`
   - **Somas:** Esquerda = 3%, Direita = 19%
   - **Avaliação:** Não válida, pois 3% < 19%.

2. **Divisão após o segundo elemento `[3, 4]`:**
   - **Primeira parte:** `[3, 4]`
   - **Segunda parte:** `[6, 2, 7]`
   - **Somas:** Esquerda = 7%, Direita = 15%
   - **Avaliação:** Não válida, pois 7% < 15%.

3. **Divisão após o terceiro elemento `[3, 4, 6]`:**
   - **Primeira parte:** `[3, 4, 6]`
   - **Segunda parte:** `[2, 7]`
   - **Somas:** Esquerda = 13%, Direita = 9%
   - **Avaliação:** Válida, pois 13% > 9%.

4. **Divisão após o quarto elemento `[3, 4, 6, 2]`:**
   - **Primeira parte:** `[3, 4, 6, 2]`
   - **Segunda parte:** `[7]`
   - **Somas:** Esquerda = 15%, Direita = 7%
   - **Avaliação:** Válida, pois 15% > 7%.

### Resultado

Para o vetor fornecido `[3, 4, 6, 2, 7]`, existem duas divisões válidas onde a soma dos retornos na primeira parte é maior que na segunda:
- Após o terceiro elemento `[3, 4, 6]`.
- Após o quarto elemento `[3, 4, 6, 2]`.

### Conclusão

Este exemplo ilustra a importância de examinar todas as divisões possíveis para encontrar aquelas que atendem ao critério de ter a soma dos retornos na primeira parte maior que na segunda. A análise passo a passo ajuda a identificar as configurações válidas do portfólio.
