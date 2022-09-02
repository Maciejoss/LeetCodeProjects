public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        int longest = 1;
        int f = 0, l = 0, i;
        bool isthere = false;

        while (l < s.Length - 1)
        {
            char next = s[l + 1];
            isthere = false;
            for (i = f; i <= l; i++)
            {
                if (next == s[i])
                {
                    isthere = true;
                    break;
                }
            }
            if (isthere) f = i + 1;
            else
            {
                l++;
                if (l - f + 1 > longest) longest = l - f + 1;
            }
        }
        return longest;
    }
}