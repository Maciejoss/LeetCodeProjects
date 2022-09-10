public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> brackets = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(') brackets.Push(')');
            else if (c == '[') brackets.Push(']');
            else if (c == '{') brackets.Push('}');
            else { if (brackets.Count == 0) return false; char a = brackets.Pop(); if (c != a) return false; }
        }
        if (brackets.Count == 0) return true;
        return false;
    }
}