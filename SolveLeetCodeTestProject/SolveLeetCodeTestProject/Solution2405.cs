
namespace SolveLeetCodeTestProject
{
    internal class Solution2405
    {    // private static bool IsHit(int goal, int start, string str)
         //     => Enumerable.Range(start, goal - start).Any(j => str[goal] == str[j]);

        // public int PartitionString(string s) 
        // {
        //     int partitionCounter = 1;
        //     int startIndex = 0;
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         if (IsHit(i, startIndex, s))
        //         {
        //             startIndex = i;
        //             partitionCounter++;
        //         }
        //     }
        //     return partitionCounter;
        // }

        internal static int PartitionString(string s)
        {
            int partitionCounter = 1;
            int startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                bool hit = false;
                for (int j = i - 1; j >= startIndex; j--)
                {
                    if (s[i] == s[j])
                    {
                        hit = true;
                        break;
                    }
                }
                if (hit)
                {
                    startIndex = i;
                    partitionCounter++;
                }
            }
            return partitionCounter;
        }
    }
}