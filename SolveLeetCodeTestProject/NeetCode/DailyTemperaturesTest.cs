namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class DailyTemperaturesTest
{
    [TestMethod]
    public void DailyTemperatures()
    {
        ReferenceEquals(DailyTemperatures([30, 38, 30, 36, 35, 40, 28]), new int[1, 4, 1, 2, 1, 0, 0]);
        ReferenceEquals(DailyTemperatures([22, 21, 20]), new int[0, 0, 0]);
    }

    //Time complexity O(n)
    //Space complexity O(n)
    public static int[] DailyTemperatures(int[] temperatures)
    {
        var list = new int[temperatures.Length];
        var stack = new Stack<(int, int)>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            var temperature = temperatures[i];
            while (stack.Count > 0 && temperature > stack.Peek().Item2)
            {
                var (idx, _) = stack.Pop();
                list[idx] = i - idx;
            }
            stack.Push((i, temperature));
        }
        return list;
    }
}

