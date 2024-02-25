int[] nums = new int[]{1,3,3,7};

int esq = 0;
int dir = nums.Length - 1;
int t = 10;

bool encontrado = false;

while (esq < dir)
{
	int x = nums[esq] + nums[dir];
	
	Console.WriteLine(x);
    
	if (x == t)
	{
		encontrado = true;
		break;
	}
	
	if (x < t)
	{
		esq++;
	}
	else
	{
		dir--;
	}
}

Console.WriteLine(encontrado);