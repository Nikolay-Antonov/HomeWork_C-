int N;
Console.WriteLine("введите число: ");
N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];

int index = 1;
while (index < N)
{
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
        index = index + 1;
    }
    index = index + 1;
}



