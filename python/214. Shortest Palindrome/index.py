from typing import List

class Solution:
    def shortestPalindrome(self, s: str) -> str:
        reversed_str = s[::-1]
        for i in range(0, len(s)):            
            prefix_s = s[0:] if i == 0 else s[0:-i]
            subfix_reversed = reversed_str[i:]                        
            if prefix_s == subfix_reversed:
                adding_str = reversed_str[0:i]
                return adding_str + s            
        return ""
