# Exercícios de Coleções Genéricas - C# Essencial

Este repositório contém exercícios focados em coleções genéricas, desenvolvidos como parte do curso **C# Essencial** com o professor **Macoratti**. Esses exercícios foram elaborados para reforçar conceitos importantes relacionados ao uso de genéricos em C#.

## Questões

### 8. Adicionar dois números inteiros usando Generics
- Escreva um programa que utiliza o conceito de Generics para adicionar dois números inteiros.

### 9. Criar uma lista de objetos Aluno
- Escreva um programa que crie uma lista de objetos `Aluno` que contém as propriedades: Nome, Idade e Sexo.
- Defina 5 objetos do tipo `Aluno` e exiba a lista de alunos no console.

### 10. Verificar se uma expressão matemática contém parênteses balanceados
- Implemente um programa que verifica se uma expressão matemática contém parênteses balanceados seguindo os passos abaixo:
  1. Crie uma variável do tipo `Stack<char>` para armazenar os parênteses abertos.
  2. Percorra cada caractere da expressão matemática.
  3. Se o caractere for um parêntese aberto ('(', '{', '['), adicione-o à pilha.
  4. Se o caractere for um parêntese fechado (')', '}', ']'), verifique se a pilha não está vazia e se o último parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o último parêntese aberto da pilha. Caso contrário, a expressão matemática não contém parênteses balanceados.
  5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver vazia, a expressão matemática contém parênteses balanceados. Caso contrário, a expressão não é balanceada.

### 11. Simular uma fila de impressão
- Implemente um programa que simula uma fila de impressão seguindo o roteiro abaixo:
  1. Crie uma variável do tipo `Queue<string>` para representar a fila de impressão.
  2. Crie um loop que irá executar até que a fila de impressão esteja vazia.
  3. Dentro do loop, verifique se a fila de impressão não está vazia. Se não estiver vazia, remova o primeiro elemento da fila usando o método `Dequeue()` e imprima na tela que o arquivo "X" está sendo impresso.
  4. Simule o tempo de impressão com um `Thread.Sleep()` por um período aleatório de tempo entre 1 e 5 segundos.
  5. Após simular a impressão do arquivo, imprima na tela que o arquivo "X" foi impresso com sucesso.
  6. Repita os passos 3 a 5 até que a fila de impressão esteja vazia.

### 12. Declarar um método genérico chamado `ReverterEImprimir`
- Escreva um programa seguindo as orientações abaixo:
  1. Declare um método genérico chamado `ReverterEImprimir` em uma classe não genérica chamada `Exemplo`.
  2. O método recebe como parâmetro um array de qualquer tipo.
  3. A seguir, declare três tipos diferentes de array: um array de `int`, um array de `string` e um array de `double`.
  4. Invoque o método duas vezes com cada array:
     - Na primeira vez, invoque o método com um determinado array, onde ele usa explicitamente o parâmetro de tipo.
     - Na segunda vez, invoque o método onde o tipo é inferido.

