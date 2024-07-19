---
theme: seriph
background: https://cover.sli.dev
title: Welcome to Slidev
info: |
  ## Slidev Starter Template
  Presentation slides for developers.

  Learn more at [Sli.dev](https://sli.dev)
class: text-center
highlighter: shiki
drawings:
  persist: false
transition: slide-left
mdc: true
---

<style>
h1 {
  background-color: #f0fff0;
  background-image: linear-gradient(45deg, #4EC5D4 10%, #146b8c 20%);
  background-size: 100%;
  -webkit-background-clip: text;
  -moz-background-clip: text;
  -webkit-text-fill-color: transparent;
  -moz-text-fill-color: transparent;
}
</style>

# C# みんなでコードレビューを試す会

# 第0回

## 松井 敏

---

# 自己紹介

- 👨 松井 敏(まつい びん)
- 👜 Codeer プログラマ(本業) & HACARUS C#&CI/CD メンター(副業)
- 🏆 Microsoft MVP for Developer Technologies 2012-2024
- 📚 Unity5 3Dゲーム開発講座 ユニティちゃんで作る本格アクションゲーム
- 💻 C#読書会主催、Greek Alphabet Software Academy TA
- ❤️ プログラム、マンガ、料理、睡眠、妻&子供

---

# LeetCode

- アカウントを作ってログイン
- [167. Two Sum II - Input Array Is Sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/)
- LeetCodeでもC#を選んで解くことは可能。無料だとインテリセンスが効かないなど制限もある。
- ローカルでVisual StudioでTestProjectを作る方が何かとおススメ（任意）
- ついでに今回用にGithubにリポジトリを作ると良いかも（任意）
- 今回はブランチを切って、マイクロコミットも試してみましょう（任意）
- LeetCodeはヒントも、答えも幾らでも書いてある。なるべく解くまでは見ない方が学びが多い。
- 同じ理由でGithub Copilotは切っておいた方が良いかも。即座に答えを提案されてしまう

---

# MSTest

```cs
namespace TestProject1;

[TestClass]
public class UnitTest1
{
    private int[] TwoSum(int[] numbers, int target)
    {
        return [];
    }

    [TestMethod]
    public void TestMethod1()
    {
        var numbers = [2, 7, 11, 15];
        var target = 9;
        var expected = [0, 1];
        var actual = TwoSum(numbers, target);
        //普通はAsseeet.AreEqualだが、配列には使えない
        CollectionAssert.AreEqual(expected, actual);
    }
}
```

---

# パラメタライズテスト

```cs
  [TestMethod]
  [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
  [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
  public void TestMethod1(int[] numbers, int target, int[] expected)
  {
      int[] actual = TwoSum(numbers, target);

      CollectionAssert.AreEqual(expected, actual);
  }
```

---

# TwoSum 例

```cs
private int[] TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (target - numbers[i] == numbers[j])
            {
                return [i + 1, j + 1];
            }
        }
    }
    return [];
}
```

---

# 計算量を考える

```cs
private int[] TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)            //O(4), O(3), O(2)
    {
        for (int j = i + 1; j < numbers.Length; j++)    //O(4 - (i + 1)), O(3 - (i + 1)), O(2 - (i + 1))
        {
            if (target - numbers[i] == numbers[j])
            {
                return [i + 1, j + 1];
            }
        }
    }
    return [];
}
```

---

# 計算量

- アルゴリズムを解く時は計算量を意識する
- 計算量は以下のルールで考える
  - 最高次数の項以外は落とす: $5x^2+10x+2$ -> $5x^2$
  - 係数を無視する: $5x^2$-> $x^2$
- 計算量はランダウのO記法を使う
- 例えば先ほどの例だと計算量は$n^2$になるので計算量はO(n^2)と書く
- 最初から計算量削減を考えるより慣れるまでは総当たりでもまず解くことが一番！

---

# 計算量 O(N^2)

```cs
private int[] TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)            //O(n)
    {
        for (int j = i + 1; j < numbers.Length; j++)    //O(n)
        {
            if (target - numbers[i] == numbers[j])
            {
                return [i + 1, j + 1];
            }
        }
    }
    return [];
}
```

---

# 計算量で係数を無視できる理由

![alt text](/image/complexityN.png)

---

# 計算量がO(n^2)以上ならO(nlogn)以下をめざす理由

![alt text](/image/complexity.png)

---

# 計算量の注意点

- ライブラリも内部で計算をしているので、計算量はかかる
- ループの中で線形探索したら、それは２重ループと一緒
- アルゴリズムを解く時はライブラリを使わずに解くのも一つ。

```cs
foreach(var student in students)
{
    var score = scores.First(x => x.StudentId == student.Id);
}
```

↓

```cs
foreach(var student in students)
{
    foreach(var score in scores)
    {
        if (score.StudentId == student.Id)
        {

        }
    }
}
```

---

# Arrange-Act-Assert(AAA)の紹介

- AAAのパターンが、テスト対象のメソッドの単体テストを記述する一般的な方法
- Arrange セクションでは、テスト対象のメソッドに渡されるデータの値を設定
- Act セクションでは、設定されたパラメーターでテスト対象のメソッドを呼び出す
- Assert セクションでは、テスト対象のメソッドの操作が予測どおりに動作することを検証する
- Given-When-Then パターンというのもある

```cs
public void TestMethod1(int[] numbers, int target, int[] expected)
{
    // Arrange

    // Act
    var actual = TwoSum(numbers, target);

    // Assert
    CollectionAssert.AreEqual(expected, actual);
}
```

---

# Fluent Assertionsの紹介

- テストコードを自然言語のように記載することができるフレームワーク

```cs
public void TestMethod1(int[] numbers, int target, int[] expected)
{
    // Arrange

    // Act
    var actual = TwoSum(numbers, target);

    // Assert
    actual.Should().BeEquivalentTo(expected);
}
```

---

# 計算量 O(N)

```cs
private int[] TwoSum(int[] numbers, int target)
{
    var map = new Dictionary<int, int>();
    for (int i = 0; i < numbers.Length; i++)
    {
        map[numbers[i]] = i;
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        if (map.TryGetValue(target - numbers[i], out var value) && value != i)
        {
            return [value + 1, i + 1];
        }
    }
}
```

---

# 2つの計算量

- 計算量には時間計算量と空間計算量の2つがある。
- 普通計算量と言えば時間計算量(time complexity)を指すことが多い
- 一方で空間計算量(space complexity)はどれほどの空間（メモリ）を使うかを表す
- 先ほどの問題はDictionaryを使っているので空間計算量は$O(n)$
- TwoSumは時間計算量$O(n)$空間計算量$O(1)$で解くことが可能

---

# 時間計算量 O(N)　空間計算量 O(1)

```cs
private int[] TwoSum(int[] numbers, int target)
{
    var left = 0;
    var right = numbers.Length - 1;
    while(left < right)
    {
        var sum = numbers[left] + numbers[right];
        if (sum == target)
        {
            return [left + 1, right + 1];
        }
        if (sum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return [];
}
```

---

# Code Rabbit

- PRして自動レビューを受けてみる

---

# Extra Stage for LINQ

- [2367. Number of Arithmetic Triplets](https://leetcode.com/problems/number-of-arithmetic-triplets/description/)

```cs
    internal int ArithmeticTriplets(int[] nums, int diff)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            map[nums[i]] = i;
        }
        var hit = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i] + diff) && map.ContainsKey(nums[i] + diff + diff))
            {
                hit++;
            }
        }
        return hit;
    }
```

---

# LINQで解く step1/4

```cs
    var map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        map[nums[i]] = i;
    }
    return nums.Where(x => map.ContainsKey(x + diff) && map.ContainsKey(x + diff + diff)).Count();
```

---

# LINQで解く step2/4

```cs
    var map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        map[nums[i]] = i;
    }
    return Count.Where(x => map.ContainsKey(x + diff) && map.ContainsKey(x + diff + diff));
```

---

# LINQで解く step3/4

```cs
    var map = nums.ToDictionary(x => x, idx => idx); //こう書きたい
    return Count.Where(x => map.ContainsKey(x + diff) && map.ContainsKey(x + diff + diff));
```

---

# LINQで解く step4/4

```cs
    var map = nums.Select((val, idx) => (val, idx)).ToDictionary(x => x.val, x => x.idx);
    return nums.Count(x => map.ContainsKey(x + diff) && map.ContainsKey(x + diff + diff));
```
