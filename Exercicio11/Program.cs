
Queue<string> filaDeImpressao = new Queue<string> ();

filaDeImpressao.Enqueue("Livro.pdf");
filaDeImpressao.Enqueue("data.txt");
filaDeImpressao.Enqueue("edital.pdf");

while(filaDeImpressao.Count > 0)
{
    string arquivo = filaDeImpressao.Dequeue();

    Console.WriteLine($"\n-O Arquivo '{arquivo}' está sendo impresso. ");

    // Simulando o tempo com o método Thread.Sleep() por um periodo entre 1 e 5  segundos
    Thread.Sleep(new Random().Next(1000, 5000));

    Console.WriteLine($"\n-O Arquivo '{arquivo}' foi impresso com sucesso.");

}


Console.ReadKey();