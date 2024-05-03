# Encontrando o Valor Inicial Mínimo para Manter a Soma Positiva

**Problema:** Você tem uma lista de números inteiros chamada `nums`. Seu objetivo é determinar um valor inicial, denominado `startValue` sendo um número positivo, que será somado aos elementos da lista `nums` de forma sequencial (da esquerda para a direita). O desafio é descobrir qual o menor valor positivo para `startValue` para que, a cada passo da soma, o resultado nunca seja menor que 1.

## Instruções:
1. Inicie com um `startValue` e o primeiro elemento de `nums`.
2. Em cada iteração, some o próximo elemento da lista ao total acumulado.
3. Caso a soma acumulada em qualquer etapa seja menor que 1, o `startValue` atual não é suficiente.
4. O objetivo é encontrar o menor `startValue` que impede que a soma total seja menor que 1 em qualquer ponto do processo.

## Objetivo:
Encontre o valor mínimo positivo para `startValue` que assegure que a soma total, ao adicionar sequencialmente os elementos de `nums`, nunca fique abaixo de 1.
