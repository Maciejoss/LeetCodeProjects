public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int a = 0, b = 1;

        while (b < s.Length / 2 + 1)
        {
            int i = a, j = b;
            while (true)
            {
                if (s[i++] != s[j++]) break;
                if (j == s.Length) return true;
            }
            while (s.Length % ++b != 0) ;
        }
        return false;
    }
}