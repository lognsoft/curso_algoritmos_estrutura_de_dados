# Desafio de Movimento em Trilha Numérica

## Introdução

Você está em uma trilha numérica e precisa determinar o ponto de partida ideal para não cair abaixo de um certo limite enquanto se move ao longo desta trilha. Cada movimento que você faz está definido em um vetor `nums`, onde cada número pode ser positivo (movimento para frente) ou negativo (movimento para trás).

## Problema

Determine o valor inicial mínimo `startValue` de modo que ao somar cada elemento do vetor `nums` sequencialmente ao total acumulado, esse total nunca seja menor que 1 em nenhum ponto do caminho.

## Detalhes do Desafio

### Entrada

- Um vetor de inteiros `nums` onde cada elemento representa um passo que pode avançar (`positivo`) ou recuar (`negativo`) na trilha numérica.

### Saída

- Um inteiro `startValue` que é o menor valor inicial possível que garante que o total acumulado nunca caia abaixo de 1, independente dos movimentos feitos conforme especificado pelo vetor `nums`.

### Exemplo

Considere o vetor `nums = [3, 4, -2, -5, 1]`. Vejamos a análise passo a passo:

1. Para que `startValue + 3 >= 1`, o `startValue` mínimo é -2.
2. Com `startValue` = -2, o total após o primeiro passo é 1. Adicionando 4, o total vai para 5.
3. Adicionando -2 ao total de 5, resulta em 3.
4. Adicionando -5 ao total de 3, resulta em -2.
5. Adicionando 1 ao total de -2, resulta em -1.

Nesse caso, percebe-se que o `startValue` mínimo não é suficiente. Após ajustes, determina-se que o menor `startValue` efetivo seria 6.

## Objetivo

- Implementar uma função que receba `nums` como entrada e retorne o `startValue` mínimo necessário.

Este problema testa a capacidade de trabalhar com acumulação de valores e condicionais, sendo relevante em contextos onde o estado deve ser mantido acima de um limiar crítico.
