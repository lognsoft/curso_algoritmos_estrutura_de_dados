//Desafio: inverta os caracteres do vetor

char[] letras = new char[] {'L', 'ó', 'g', 'i', 'c', 'a'};

int esq = 0;
int dir = letras.Length -1;

while (esq < dir)
{
	char temp = letras[esq];
	letras[esq] = letras[dir];
	letras[dir] = temp;
	
	esq++;
	dir--;
}

for (int i = 0; i < letras.Length; i++)
{
	Console.Write(letras[i]);
}