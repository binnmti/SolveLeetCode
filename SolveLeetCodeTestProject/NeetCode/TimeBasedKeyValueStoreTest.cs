using System.Linq;

namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class TimeBasedKeyValueStoreTest
{
    [TestMethod]
    public void TimeBasedKeyValueStore()
    {
        TimeMap timeMap = new TimeMap();
        timeMap.Set("key1", "value1", 10);
        timeMap.Get("key1", 1);
        timeMap.Get("key1", 10);
        timeMap.Get("key1", 11);

        //TimeMap timeMap = new TimeMap();
        //timeMap.Set("foo", "bar", 1);
        //timeMap.Get("foo", 1);
        //timeMap.Get("foo", 3);
        //timeMap.Set("foo", "bar2", 4);
        //timeMap.Get("foo", 4);
        //timeMap.Get("foo", 5);

        //TimeMap timeMap = new TimeMap();
        //timeMap.Set("alice", "happy", 1);  // store the key "alice" and value "happy" along with timestamp = 1.
        //timeMap.Get("alice", 1);           // return "happy"
        //timeMap.Get("alice", 2);           // return "happy", there is no value stored for timestamp 2, thus we return the value at timestamp 1.
        //timeMap.Set("alice", "sad", 3);    // store the key "alice" and value "sad" along with timestamp = 3.
        //timeMap.Get("alice", 3);           // return "sad"
    }

    //Time complexity O(n lon n)
    //Space complexity O(n)
    //public int CarFleet(int target, int[] position, int[] speed)
    //{
    //}
}


public class TimeMap
{
    Dictionary<string, Dictionary<int, string>> dic = new();

    public TimeMap()
    {
    }

    public void Set(string key, string value, int timestamp)
    {
        if (dic.TryGetValue(key, out Dictionary<int, string>? v))
        {
            v.Add(timestamp, value);
        }
        else
        {
            var v2 = new Dictionary<int, string>
            {
                { timestamp, value }
            };
            dic.Add(key, v2);
        }
    }


    public string Get(string key, int timestamp)
    {
        if (!dic.TryGetValue(key, out Dictionary<int, string>? hit)) return "";
        if (hit.TryGetValue(timestamp, out string? value))
        {
            return value;
        }
        else
        {
            string last = "";
            foreach (var kvp in hit)
            {
                if (kvp.Key < timestamp)
                {
                    last = kvp.Value;
                }
            }
            return last;
        }
    }
}


