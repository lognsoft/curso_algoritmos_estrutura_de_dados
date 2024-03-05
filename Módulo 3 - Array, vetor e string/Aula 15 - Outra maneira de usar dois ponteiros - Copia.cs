string s1 = "adefiejijffadefiejijff";
string s2 = "abcdefg";

void ON()
{
	int i = 0;
	int t = 0;
	int c = 0;
	int passos = 0;
	
	while (i < s1.Length && t < s2.Length)
	{
		passos++;
		if (s1[i] == s2[t])
		{
			i++;
			c++;
		}
		t++;
	}
	Console.WriteLine(c == s1.Length);
	Console.WriteLine("ON "+passos);
}


ON();
Console.WriteLine("----------------");
ON2();

void ON2()
{
	int passos = 0;
	int c = 0;
	int ultima = 0;

//O(n)
	for (int i = 0; i < s1.Length; i++) //O(n)
	{
		for (int t = ultima; t < s2.Length; t++) //O(n)
		{
			passos++;
			if (s1[i] == s2[t])
			{

				ultima = t + 1;
				c++;
				break;
				
			}
		}
	}

	Console.WriteLine(c == s1.Length);
	Console.WriteLine("ON2 "+passos);
}
