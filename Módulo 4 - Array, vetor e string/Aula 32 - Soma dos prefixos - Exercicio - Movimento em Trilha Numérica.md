# Encontrando o Valor Inicial Mínimo para Manter a Soma Positiva

**Problema:** Você tem uma lista de números inteiros chamada `nums`. Seu objetivo é determinar um valor inicial, denominado `valorInicial` sendo um número positivo, que será somado aos elementos da lista `nums` de forma sequencial (da esquerda para a direita). O desafio é descobrir qual o menor valor positivo para `valorInicial` para que, a cada passo da soma, o resultado nunca seja menor que 1.

## Instruções:
1. Inicie com um `valorInicial` e o primeiro elemento de `nums`.
2. Em cada iteração, some o próximo elemento da lista ao total acumulado.
3. Caso a soma acumulada em qualquer etapa seja menor que 1, o `valorInicial` atual não é suficiente.
4. O objetivo é encontrar o menor `valorInicial` que impede que a soma total seja menor que 1 em qualquer ponto do processo.

## Entrada:
[3, 4, -2, -7, 1]

## Objetivo:
Encontre o valor mínimo positivo para `valorInicial` que assegure que a soma total, ao adicionar sequencialmente os elementos de `nums`, nunca fique abaixo de 1.
