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
nums = [2, 2, 5, 10, 3]