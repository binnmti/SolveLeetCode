namespace SolveLeetCodeTestProject;

internal static class Solution445
{
    internal static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
        => Solution002.AddTwoNumbers(l1.Reverse(), l2.Reverse()).Reverse();
}
