using System.Linq;

namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class TimeBasedKeyValueStoreTest
{
    [TestMethod]
    public void TimeBasedKeyValueStore()
    {
        //TimeMap timeMap = new TimeMap();
        //timeMap.Set("key1", "value1", 10);
        //timeMap.Get("key1", 1);
        //timeMap.Get("key1", 10);
        //timeMap.Get("key1", 11);

        //TimeMap timeMap = new TimeMap();
        //timeMap.Set("foo", "bar", 1);
        //timeMap.Get("foo", 1);
        //timeMap.Get("foo", 3);
        //timeMap.Set("foo", "bar2", 4);
        //timeMap.Get("foo", 4);
        //timeMap.Get("foo", 5);

        TimeMap timeMap = new TimeMap();
        timeMap.Set("alice", "happy", 1);  // store the key "alice" and value "happy" along with timestamp = 1.
        var x = timeMap.Get("alice", 1);           // return "happy"
        var y = timeMap.Get("alice", 2);           // return "happy", there is no value stored for timestamp 2, thus we return the value at timestamp 1.
        timeMap.Set("alice", "sad", 3);    // store the key "alice" and value "sad" along with timestamp = 3.
        var z = timeMap.Get("alice", 3);           // return "sad"
    }
}


public class TimeMap
{
    Dictionary<string, List<(int, string)>> dic = new();

    public TimeMap()
    {
    }

    public void Set(string key, string value, int timestamp)
    {
        if (dic.TryGetValue(key, out var v))
        {
            v.Add((timestamp, value));
        }
        else
        {
            dic.Add(key, new List<(int, string)> { { (timestamp, value) } });
        }
    }

    public string Get(string key, int timestamp)
    {
        if (!dic.TryGetValue(key, out var hit))
        {
            return "";
        }
        var l = 0;
        var r = hit.Count - 1;
        string last = "";
        while (l <= r)
        {
            var c = l + (r - l) / 2;
            if (hit[c].Item1 <= timestamp)
            {
                last = hit[c].Item2;
                l = c + 1;
            }
            else
            {
                r = c - 1;
            }
        }
        return last;
    }
}


