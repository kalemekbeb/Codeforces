string rectInput = Console.ReadLine();
string[] rectangle = rectInput.Split();
int M = int.Parse(rectangle[0]);
int N = int.Parse(rectangle[1]);

int output = M * N / 2;
Console.WriteLine(output);
