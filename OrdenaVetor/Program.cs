/*
 3 - faça um programa que leia 5 numeros, guarde os em um vetor e ordene os de forma crescente em um novo vetor.
 */
int tamanho = 10;
int[] vetor = new int[tamanho];
int[] ordenado = new int[tamanho];
int aux;
int j = 0;

for (int i = 0; i < tamanho; i++)
{
    //Console.Write($"Digite o {i + 1}º valor: ");
    //vetor[i] = int.Parse(Console.ReadLine());

    vetor[i] = new Random().Next(0, 5);
    ordenado[i] = vetor[i];
}
Console.WriteLine("Original: ");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < tamanho; i++)
{
    for (j = i + 1; j < tamanho; j++)
    {
        if (ordenado[i] > ordenado[j])
        {
            aux = ordenado[i];
            ordenado[i] = ordenado[j];
            ordenado[j] = aux;
        }
    }
}
Console.WriteLine("Vetor ordenado:");

for(int i = 0;i < tamanho; i++)
    Console.Write(ordenado[i] + " ");


Console.WriteLine();
Console.WriteLine("Vetor ordenado SEM REPETICAO:");

bool repete = false;


for (int i = 0; i < tamanho; i++)
{
    repete = false;

    for (j = i + 1; j < tamanho; j++)
    {
        if (ordenado[i] == ordenado[j])
        {
            repete = true;
            j = tamanho;
        }
    }

    if (repete == false)
        Console.Write(ordenado[i] + " ");
    
}

Console.WriteLine();
Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();