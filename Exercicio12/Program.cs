

int[] arrayInteiro = { 1, 2, 3, 4, 5 };
string[] arrayString = { "André", "Rafael", "Gabriela" };
double[] arrayDouble = { 4.5, 5.5, 2.2, 8.3, 1.9 };

Console.WriteLine("\nArray de Inteiros: ");
Generica.ReverterEImprimir<int>(arrayInteiro);
Generica.ReverterEImprimir(arrayInteiro);

Console.WriteLine("\nArray de string: ");
Generica.ReverterEImprimir<string>(arrayString);
Generica.ReverterEImprimir(arrayString);

Console.WriteLine("\nArray de double:");
Generica.ReverterEImprimir<double>(arrayDouble);
Generica.ReverterEImprimir(arrayDouble);


Console.ReadKey();
class Generica
{
    public static void ReverterEImprimir<T>(T[] colecao)
    {
        Array.Reverse(colecao);
        Console.WriteLine("Array Revertido:");
        foreach (T item in colecao)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();
    }
}
