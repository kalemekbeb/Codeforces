string kn = Console.ReadLine();
string[] nums = kn.Split();
int n = int.Parse(nums[0]);
int k = int.Parse(nums[1]);

string scores = Console.ReadLine();
string[] scoreArr = scores.Split();

int scoreLessThanK = (int.Parse(scoreArr[k - 1]));
int scoreCount = 0;
for (var i=0; i<scoreArr.Length; i++)
{
    int score = int.Parse(scoreArr[i]);
    if (score >= scoreLessThanK && score > 0)
    {
        scoreCount++;
    }
}
Console.WriteLine(scoreCount);



