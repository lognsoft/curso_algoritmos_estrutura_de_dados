Random rand = new Random();

int[] nums = Enumerable.Range(0, 99999).Select(_ => rand.Next(51)).ToArray();

//somaAcadaBusca
somaPrefixo();

void somaAcadaBusca()
{
    int count = 0;

    while (true) {

        Console.WriteLine("digite inicio");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite fim");
        int fim = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        for(int i = inicio; i <= fim; i++)
        {
            Console.WriteLine(i);
            count++;
            resultado += nums[i];
        }

        Console.WriteLine("resultado: " + resultado + " iteracoes: " + count);
    }
}

void somaPrefixo() {

    int count = 0;
    
    int[] prefixo = new int[nums.Length];

    prefixo[0] = nums[0];

    for (int i = 1; i < prefixo.Length; i++)
    {
        Console.WriteLine(i);
        prefixo[i] = nums[i] + prefixo[i - 1];
        count++;
    }

    while (true)
    {
        count++;
        Console.WriteLine("digite inicio");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite fim");
        int fim = Convert.ToInt32(Console.ReadLine());

        int resultado;

        if (inicio == 0)
        {
            resultado = prefixo[fim];
        }
        else
        {
            resultado = prefixo[fim] - prefixo[inicio - 1];
        }

        Console.WriteLine("resultado: " + resultado + " iteracoes: " + count);

    }
}