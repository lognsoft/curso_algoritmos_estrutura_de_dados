int[] nums = new []{3,2,4,5,6,3,6,7};


int target = 6;

int direita = 0;
int esquerda = nums.Length - 1;

while (direita <= esquerda)
{

	if (nums[direita] == target || nums[esquerda] == target)
	{
		Console.WriteLine("encontrado");
		break;
	}
	
	direita++;
	esquerda--;
}