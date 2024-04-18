namespace ConsoleApp7;

public class MatrizDinamica
{
	public int Count { get; set; }
	public int[] Vetor { get; set; } = new int[2];

	public void Add(int item)
	{
		if (Count == Vetor.Length)
		{
			int[] tempVet = new int[Count * 2];

			for (int i = 0; i < Vetor.Length; i++)
			{
				tempVet[i] = Vetor[i];
			}
			Vetor = tempVet;
		}
		Vetor[Count] = item;
		Count++;
	}

	public int Get(int pos)
	{
		if (pos >= 0 && pos <= Count)
		{
			return Vetor[pos];
		}
		throw new ArgumentException("item nao encontrado no vetor");
	}

	public void Delete(int pos)
	{
		if (pos >= 0 && pos <= Count)
		{
			for (int i = pos; i < Count - 1; i++)
			{
				Vetor[i] = Vetor[i + 1];
			}		
			Count--;
		}
		else
		{
			throw new ArgumentException("item nao encontrado no vetor");
		}
	}

	public void Edit(int pos, int value)
	{
		if (pos >= 0 && pos <= Count)
		{
			Vetor[pos] = value;
		}
		else
		{
			throw new ArgumentException("item nao encontrado no vetor");
		}
	}
	
}