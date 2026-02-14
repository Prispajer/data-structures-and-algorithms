public class Solution {
    public int StrStr(string haystack, string needle) {
        int read = 0; 
        int start = 0;
        int end = start + needle.Length;

        if (haystack.Length < 1 || needle.Length < 1) {
            return -1;
        }

        while (read < haystack.Length) {
            while (start <= haystack.Length - needle.Length) {
                if (haystack.Substring(start, needle.Length) == needle) {
                    return start;
                }

                start++;
            }
            return -1;
        }

        if (end > haystack.Length) {
            return -1;
        }

        Console.WriteLine(end);
        return start;
    }
}