
namespace SolveLeetCodeTestProject
{
    internal class Solution2405
    {
        //private static bool IsHit(int start, int goal, string str)
        //     => Enumerable.Range(start, goal - start).Any(x => str[x] == str[goal]);

        //internal static int PartitionString(string s)
        //{
        //    int partitionCounter = 1;
        //    int startIndex = 0;
        //    Enumerable.Range(startIndex, s.Length).ToList().ForEach(i =>
        //    {
        //        if (!IsHit(startIndex, i, s)) return;

        //        startIndex = i;
        //        partitionCounter++;
        //    });
        //    return partitionCounter;
        //}

        internal static int PartitionString(string s)
        {
            int partitionCounter = 1;
            int startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = startIndex; j < i; j++)
                {
                    if (s[i] != s[j]) continue;

                    startIndex = i;
                    partitionCounter++;
                    break;
                }
            }
            return partitionCounter;
        }
    }
}