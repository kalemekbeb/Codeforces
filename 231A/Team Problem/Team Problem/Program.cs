// if sum of inputs >= 2 output = count++

int n = int.Parse(Console.ReadLine());

//for(int i = 0; < n; i++)
int count = 0;
for (int problemCnt = 0; problemCnt < n; problemCnt++)
{
    string problem = Console.ReadLine();
    string[] parts = problem.Split();

    int p = int.Parse(parts[0]);
    int v = int.Parse(parts[1]);
    int t = int.Parse(parts[2]);

    if (p + v + t >= 2)
    {
        count++;
    }
}
Console.WriteLine(count);


