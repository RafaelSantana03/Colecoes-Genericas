

// Expressão 
using System.Linq.Expressions;

string expressao = "(1 + 2) * 3) - 4";

bool balenceada = EstaBalanceada(expressao);

Console.WriteLine($"A expressão matemática {expressao} é {(balenceada ?
                   "esta balanceada" : "não esta balanceada")}.");

static bool EstaBalanceada(string expressao)
{
    // Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos. 
    Stack<char> parentesesAbertos = new Stack<char>();

    // Percorra cada caractere da expressão matemática.
    foreach (var item in expressao)
    {
        // Se o caractere for um parêntese aberto ( '(', '{', '['), adicione-o à pilha.
        if (item == '(' || item == '{' || item == '[')
        {
            parentesesAbertos.Push(item);
        }
        // Se o caractere for um parêntese fechado ( ')', '}', ']' ), verifique se a pilha não está vazia
        else if (item == ')' || item == '}' || item == ']')
        {
            if (parentesesAbertos.Count == 0)
            {
                return false;
            }

            char ultimoParenteses = parentesesAbertos.Pop();
            
            if ((item == ')' && ultimoParenteses != '(') ||
                    (item == '}' && ultimoParenteses != '{') ||
                (item == ']' && ultimoParenteses != '['))
            {
                return false;
            }
        }
    }
    return parentesesAbertos.Count == 0;
}


