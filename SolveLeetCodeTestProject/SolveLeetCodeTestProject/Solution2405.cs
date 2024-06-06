
namespace SolveLeetCodeTestProject
{
    internal class Solution2405
    {
        internal static int PartitionString(string s)
        {
            int co = 1;
            var hits = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (hits.Any(x => x == s[i]))
                {
                    co++;
                    hits.Clear();
                }
                hits.Add(s[i]);
            }
            return co;
        }
    }
}