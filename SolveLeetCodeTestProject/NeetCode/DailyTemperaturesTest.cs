namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class DailyTemperaturesTest
{
    [TestMethod]
    public void DailyTemperatures()
    {
        Assert.ReferenceEquals(DailyTemperatures([30, 38, 30, 36, 35, 40, 28]), new int [1, 4, 1, 2, 1, 0, 0]);
        Assert.ReferenceEquals(DailyTemperatures([22, 21, 20]), new int[0, 0, 0]);
    }

    public static int[] DailyTemperatures(int[] temperatures)
    {
        var warmerDays = new List<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            bool hit = false;
            int day = 1;
            for (int j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[i] < temperatures[j])
                {
                    warmerDays.Add(day);
                    hit = true;
                    break;
                }
                day++;
            }
            if (!hit)
            {
                warmerDays.Add(0);
            }
        }
        return warmerDays.ToArray();
    }
}

