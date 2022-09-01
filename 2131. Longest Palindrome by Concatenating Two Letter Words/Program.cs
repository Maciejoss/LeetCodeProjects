public class Solution {
        public int LongestPalindrome(string[] words)
        {
            int[,] letters = new int[26,26];
            int count = 0;
            foreach (var item in words)
            {
                if (letters[item[1] - 'a', item[0] - 'a'] >= 1) { count+=2; letters[item[1] -                         'a', item[0] - 'a'] --; }
                else letters[item[0] - 'a', item[1] - 'a']++;
            }
            for(int i=0;i<26;i++)
            {
                if (letters[i, i] >= 1) { count++;break; }
            }
            return count*2;
        }
}