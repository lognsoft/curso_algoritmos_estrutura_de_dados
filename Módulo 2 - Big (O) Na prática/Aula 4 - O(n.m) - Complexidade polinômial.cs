using System;


string senhaCorreta = "1234";
string senhaQuebrada = "";

Console.WriteLine("Iniciando quebra de senha...");

for (int d1 = 0; d1 <= 9; d1++)
{
	for (int d2 = 0; d2 <= 9; d2++)
	{
		for (int d3 = 0; d3 <= 9; d3++)
		{
			for (int d4 = 0; d4 <= 9; d4++)
			{
				senhaQuebrada = $"{d1}{d2}{d3}{d4}";
				Console.WriteLine($"Tentando senha: {senhaQuebrada}");

				if (senhaQuebrada == senhaCorreta)
				{
					Console.WriteLine("Senha quebrada com sucesso: " + senhaQuebrada);
					return;
				}
			}
		}
	}
}
Console.WriteLine("Senha não encontrada.");