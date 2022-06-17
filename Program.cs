using BigText;
using Figgle;


int maior;
int menor;

do
{
    Console.WriteLine("Qual o MENOR número?\n");

    menor = BText.leNumero();

    Console.WriteLine("Qual o MAIOR número?\n");

    maior = BText.leNumero();

    if(maior <= menor)
    {
        Console.Clear();
        Console.WriteLine("O MAIOR deve ser maior que o MENOR.\n");
        Console.WriteLine("Vamos tentar de novo...\n");
    }

} while (maior <= menor);

Console.Clear();

int quantNumeros = (maior - menor) + 1;
ConsoleKey key;
int mockSize = 20;
int mockDelay = 50;
int mockInt;
Random rd = new Random();

int numeroSorteado;
List<int> numerosSorteados = new List<int>();

Console.WriteLine(
            FiggleFonts.Slant.Render("_ _"));

do
{
    Console.WriteLine("\nDigite Espaço ou Enter para sortear...");
    key = Console.ReadKey().Key;

    if (key == ConsoleKey.Enter || key == ConsoleKey.Spacebar)
    {
        Console.Clear();
        for (int i = 0; i < mockSize; i++)
        {
            mockInt = rd.Next(menor, maior+1);
            Console.Clear();
            BText.show(mockInt);
            System.Threading.Thread.Sleep(mockDelay);
        }
        Console.Clear();
        numeroSorteado = BText.escolheNumeroNaoEscolhido(menor, maior+1, numerosSorteados);
        numerosSorteados.Add(numeroSorteado);
        BText.show(numeroSorteado);
        Console.WriteLine();
        string foram = (numerosSorteados.Count() > 1 ) ? "foram" : "foi" ;
        string sorteados = (numerosSorteados.Count() > 1 ) ? "sorteados" : "sorteado";
        Console.WriteLine("{0} números já {1} {2} (de um total de {3}).\n", numerosSorteados.Count(), foram, sorteados, quantNumeros);
        BText.mostraNumerosEscolhidos(numerosSorteados);
        Console.WriteLine();
    }

} while (numerosSorteados.Count<quantNumeros);

Console.ReadKey();
Console.Clear();
Console.WriteLine("Não há mais números a serem sorteados");
Console.ReadKey();





