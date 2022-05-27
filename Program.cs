Console.WriteLine("Tamanho do retangulo: ");

Console.Write("largura..: ");
int largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura..: ");
int altura = Convert.ToInt32(Console.ReadLine());

if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
{
    Console.WriteLine("As medidas devem estar entre 1 e 10.");
}
else
{
    int linhaAtual = 1;
    while (linhaAtual <= altura)
    {
        Console.WriteLine();

        int colunaAtual = 1;
        while (colunaAtual <= largura)
        {
            if (linhaAtual == 1 || linhaAtual == altura)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("");
            }
        }
         colunaAtual += 1;
    }

    linhaAtual += 1;
}

        

