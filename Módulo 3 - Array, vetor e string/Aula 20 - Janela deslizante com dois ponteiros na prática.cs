
int[] nums = new[] { 1,2,4,2,1,1 };

Console.WriteLine("O(N)");
ON();//Janela deslizante

Console.WriteLine("----------------------");

Console.WriteLine("O(N^2)");
ON2();

void ON2()//Força bruta
{
	int t = 5;
	int res = 0;
	int counter = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		int somaTotal = 0;
		for (int j = i; j < nums.Length; j++)
		{
			somaTotal += nums[j];
			counter++;
			
			Console.Write(nums[j]+",");
			if (somaTotal <= t)
			{
				res = Math.Max(res, j - i + 1);
			}
		}
		Console.WriteLine();

	}

	Console.WriteLine("Sequencia: " + res);
	Console.WriteLine("Número de etapas: " + counter);
}


void ON()
{
	

	int left = 0;
	int somaTotal = 0;
	int res = 0;
	int t = 5;
	int counter = 0;

	for (int right = 0; right < nums.Length; right++)
	{
		
		somaTotal += nums[right];
		counter++;
		
		Console.WriteLine("ponteiro esquerda: "+nums[left] + " - ponteiro direita: " + nums[right]);

		while (somaTotal > t)
		{
			
			somaTotal -= nums[left];
			left++;
			counter++; 
			
			
		}

		int pos = right - left + 1;
		
		res = Math.Max(pos, res);
	}
	
	Console.WriteLine("Sequencia: " + res);
	Console.WriteLine("Número de etapas: " + counter);
}