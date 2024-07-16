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

# C# みんなでコードレビューを試す会 第0回

# 松井 敏

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
- LeetCodeでもC#を選んで解くことは可能。インテリセンスが効かないなど制限もある。
- ローカルでTestProjectを作る方がおススメ

---

# TestProject

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
        int[] numbers = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [0, 1];
        int[] result = TwoSum(numbers, target);
        //普通はAsseeet.AreEqualだが、配列には使えない
        CollectionAssert.AreEqual(expected, result);
    }
}
```

---

# TwoSum Ansewer

```cs
private int[] TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (target - numbers[i] == numbers[j])
            {
                return [i, j];
            }
        }
    }
    return [];
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

# Arrange-Act-Assert(AAA)

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

# Fluent Assertions

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

# 計算量

- アルゴリズムを解く時は計算量を意識する
- 計算量は、

---

# 計算量

![alt text](/image/complexity.png)

---

# 計算量

![alt text](/image/complexityN.png)

```

```
