int[,] grid = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    string[] parts = Console.ReadLine().Split();
    for (int j = 0; j < 5; j++)
    {
        grid[i, j] = int.Parse(parts[j]);
    }
}

int oneRow = 0;
int oneCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (grid[i, j] == 1)
        {
            oneRow = i;
            oneCol = j;
        }
    }
}

Console.WriteLine(Math.Abs(oneRow - 2) + Math.Abs(oneCol - 2));