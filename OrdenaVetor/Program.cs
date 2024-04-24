/*
 3 - faça um programa que leia 5 numeros, guarde os em um vetor e ordene os de forma crescente em um novo vetor.
 */
int tamanho = 20;
int[] vetor = new int[tamanho];
int[] ordenado = new int[tamanho];
int[] ordenadoDecrescente = new int[tamanho];
bool repete = false;
int aux = 0, j = 0;

for (int i = 0; i < tamanho; i++)
{
    //Console.Write($"Digite o {i + 1}º valor: ");
    //vetor[i] = int.Parse(Console.ReadLine());

    vetor[i] = new Random().Next(0, 200);
    ordenado[i] = vetor[i];
    ordenadoDecrescente[i] = vetor[i];
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

for (int i = 0; i < tamanho; i++)
{
    for (j = i + 1; j < tamanho; j++)
    {
        if (ordenadoDecrescente[i] < ordenadoDecrescente[j])
        {
            aux = ordenadoDecrescente[i];
            ordenadoDecrescente[i] = ordenadoDecrescente[j];
            ordenadoDecrescente[j] = aux;
        }
    }
}



Console.WriteLine("Vetor ordenado Decrescente:");

for (int i = 0; i < tamanho; i++)
{
    Console.Write(ordenadoDecrescente[i] + " ");
}

Console.WriteLine();
Console.WriteLine("Vetor ordenado Decrescente SEM REPETICAO:");

for (int i = 0; i < tamanho; i++)
{
    repete = false;
    for (j = i + 1; j < tamanho; j++)
    {
        if (ordenadoDecrescente[i] == ordenadoDecrescente[j])
        {
            repete = true;
            j = tamanho;
        }
    }
    if (repete == false)
    {
        Console.Write(ordenadoDecrescente[i] + " ");
    }
}


Console.WriteLine();
Console.WriteLine("Vetor ordenado:");

for (int i = 0; i < tamanho; i++)
    Console.Write(ordenado[i] + " ");


Console.WriteLine();
Console.WriteLine("Vetor ordenado SEM REPETICAO:");


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