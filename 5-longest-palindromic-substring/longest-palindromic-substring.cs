public class Solution {
    public string LongestPalindrome(string s) {
        int bestLength = 0;
        int bestStart = 0;

        for (int i = 0; i < s.Length; i++) {
            int left = i; 
            int right = i;

            int oddLength = MovePointers(s, i, i);
            int evenLength = MovePointers(s, i, i + 1);

            int maxLength = Math.Max(oddLength, evenLength);

            if(bestLength < maxLength){
                bestLength = maxLength;
                bestStart = i - (maxLength - 1) / 2;
            }
        }
        
        return s.Substring(bestStart, bestLength);
    }

    private int MovePointers(string s, int left, int right){
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }

        return right - left - 1;
    }
} 