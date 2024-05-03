# Desafio do Valor Inicial para Saldo Positivo na Sequência Numérica

## Introdução

Este problema requer o cálculo do valor inicial mínimo, denominado `startValue`, necessário para que um saldo acumulado não caia abaixo de 1 ao aplicar sequencialmente os elementos de um vetor de inteiros `nums`. Cada elemento do vetor pode ser positivo, aumentando o saldo, ou negativo, reduzindo-o.

## Descrição do Problema

Determinar o `startValue` mínimo que, quando somado aos elementos de `nums`, garante que o saldo acumulado nunca seja inferior a 1, independentemente das variações apresentadas pelo vetor.

## Entrada

- Um vetor de inteiros `nums`, onde cada elemento indica um ajuste no saldo enquanto se avança na sequência numérica.

## Saída

- Um inteiro `startValue`, o menor valor inicial que mantém o saldo acumulado sempre acima de 1 ao longo da aplicação dos elementos do vetor `nums`.

## Exemplo

Para `nums = [3, 4, -2, -7, 1]`:

### Análise Inicial com Saldo de Teste:
- Assumindo um `startValue` hipotético de 1:
  - Saldo após adicionar 3: 4
  - Saldo após adicionar 4: 8
  - Saldo após subtrair 2: 6
  - Saldo após subtrair 7: -1 (saldo cai abaixo de 1)
  - Saldo após adicionar 1: 0

### Determinação do `startValue` necessário:
- Avaliando a partir de um saldo inicial de 0:
  - Saldo inicial: 0
  - Após 3: 3
  - Após 4: 7
  - Após -2: 5
  - Após -7: -2 (ponto mais baixo alcançado)
  - Após 1: -1
- O saldo mínimo registrado é -2. Para garantir que o saldo seja sempre pelo menos 1, `startValue` precisa ser:
  - `startValue = 3` (para elevar o menor saldo de -2 para 1).

## Objetivo

Implementar uma função que receba o vetor `nums` e retorne o `startValue` mínimo necessário para que o saldo sempre permaneça acima de 1 durante todo o trajeto indicado pela sequência numérica. Este desafio é crucial para entender como manter um estado positivo sob condições variáveis em sequências de operações.
