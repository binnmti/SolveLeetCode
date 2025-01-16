namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class CarFleetTest
{
    [TestMethod]
    public void CarFleet()
    {
        Assert.AreEqual(CarFleet(31, [5, 26, 18, 25, 29, 21, 22, 12, 19, 6], [7, 6, 6, 4, 3, 4, 9, 7, 6, 4]), 6);
        Assert.AreEqual(CarFleet(20, [6, 2, 17], [3, 9, 2]), 2);
        Assert.AreEqual(CarFleet(10, [8, 3, 7, 4, 6, 5], [4, 4, 4, 4, 4, 4]), 6);
        Assert.AreEqual(CarFleet(10, [0, 4, 2], [2, 1, 3]), 1);
        Assert.AreEqual(CarFleet(10, [1, 4], [3, 2]), 1);
        Assert.AreEqual(CarFleet(10, [4, 1, 0, 7], [2, 2, 1, 1]), 3);
    }

    //Time complexity O(n lon n)
    //Space complexity O(n)
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var positionAndSpeeds = position.Select((p, idx) => (p, speed[idx])).OrderByDescending(x => x.p);
        var stack = new Stack<double>();
        foreach (var (p, s) in positionAndSpeeds)
        {
            stack.Push(((double)target - p) / s);
            if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
            {
                stack.Pop();
            }
        }
        return stack.Count;
    }
}

