public class Solution {

    public int StrStr(string haystack, string needle)
    {
        int[] T = CreateT(needle);

        int i = 0, j = 0;

        while (i < haystack.Length - needle.Length + j + 1)
        {
            if (haystack[i] == needle[j])
            {
                i++; j++;
                if (j == needle.Length) return i - j;
            }
            else if (j != 0) j = T[j - 1];
            else i++;
        }

        return -1;
    }

    public int[] CreateT(string x)
    {
        int[] T = new int[x.Length];
        T[0] = 0;
        int i = 0, j = 1;

        while (j < x.Length)
        {
            if (x[i] == x[j])
            {
                T[j] = i + 1;
                j++;
                i++;
            }
            else if (i != 0) i = T[i - 1];
            else j++;
        }

        return T;
    }
}
