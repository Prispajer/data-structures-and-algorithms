public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        var romanNumbers = new Dictionary<string, int>{
            ["I"] = 1,
            ["V"] = 5,
            ["X"] = 10,
            ["L"] = 50,
            ["C"] = 100,
            ["D"] = 500,
            ["M"] = 1000,
        };

        for(int i = 0; i < s.Length; i++){
            int current = romanNumbers[s[i].ToString()];
            int next = i + 1 < s.Length ? romanNumbers[s[i + 1].ToString()] : 0;
            
            if(current < next)
            {
                result = result + (next - current);
                i++;
            }
            else{
                result = result + current;  
            }
        }

        return result;
    }
}