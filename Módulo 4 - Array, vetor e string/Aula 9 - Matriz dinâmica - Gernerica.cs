namespace ConsoleApp7;

public class MatrizDinamica <T>
{
	public int Count { get; set; }
	private T[] Vetor { get; set; } = new T[2];

	public T this[int index]
	{
		get { return Vetor[index]; }
		set
		{
			if (index >= 0 && index < Count)
			{
				Vetor[index] = value;
			}
			else
			{
				throw new ArgumentException("item nao encontrado no vetor");
			}
		}
	}
	
	
	public void Add(T item)
	{
		if (Count == Vetor.Length)
		{
			T[] tempVet = new T[Count * 2];

			for (int i = 0; i < Vetor.Length; i++)
			{
				tempVet[i] = Vetor[i];
			}
			Vetor = tempVet;
		}
		Vetor[Count] = item;
		Count++;
	}

	public T Get(int pos)
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

	/*public void Edit(int pos, T value)
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
	*/
}