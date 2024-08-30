using System.Collections;

Console.WriteLine("##  Exercício 9  ##\n");

List<Aluno> aluno = new List<Aluno>() 
{
    (new Aluno("Rafael", 20, "Masculino")),
    (new Aluno("Pedro", 22, "Masculino")),
    (new Aluno("João", 18, "Masculino")),
    (new Aluno("Gabriela", 20, "Feminino")),
    (new Aluno("Yasmin", 19, "Feminino")),
};

foreach (var item in aluno)
{
    Console.WriteLine();
    Console.WriteLine($"{item.Nome}, Idade: {item.Idade}, Sexo: {item.Sexo}");
}

Console.ReadKey();
public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string Sexo { get; set; }

    public Aluno(string? nome, int idade, string sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }
}
