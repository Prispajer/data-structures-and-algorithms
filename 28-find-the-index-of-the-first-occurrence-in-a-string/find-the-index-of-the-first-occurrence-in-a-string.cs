public class Solution {
    public int StrStr(string haystack, string needle) {
        int start = 0;
        int end = needle.Length;

        if (haystack.Length < 1 || needle.Length < 1) {
            return -1;
        }

        while (start <= haystack.Length - needle.Length) {
            if (haystack.Substring(start, needle.Length) == needle) {
                return start;
            }
            start++;
        }
        return -1;
     

        if (end > haystack.Length) {
            return -1;
        }

        return start;
    }
}