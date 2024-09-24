from typing import List, Set

class Solution:
    def longestCommonPrefix(self, arr1: List[int], arr2: List[int]) -> int:
        maxLen: int = 0
        int_set: Set[int] = set()
        for num in arr1:
            reduce_num = num
            while reduce_num > 0:
                int_set.add(reduce_num)
                reduce_num //= 10

        for num in arr2:
            reduce_num = num
            while reduce_num > 0:
                if reduce_num in int_set:
                    maxLen = max(maxLen, len(str(reduce_num)))
                    break
                reduce_num //= 10
        return maxLen
    
class Solution2:
    def longestCommonPrefix(self, arr1: List[int], arr2: List[int]) -> int:
        maxLen: int = 0
        trie = Trie()
        
        for num in arr1:
            trie.insert(num)

        for num in arr2:
            len = trie.find_longest_prefix(num)
            maxLen = max(maxLen, len)
            
        return maxLen

class TrieNode:
    def __init__(self) -> None:
        self.children= [None]*10

class Trie:
    def __init__(self) -> None:
        self.root = TrieNode()

    def insert(self, num):
        node = self.root
        num_str = str(num)
        for digit in num_str:
            index = int(digit)
            if not node.children[index]:
                node.children[index] = TrieNode()
            node = node.children[index]

    def find_longest_prefix(self, num):
        len=0
        node = self.root
        num_str = str(num)
        for digit in num_str:
            index = int(digit)
            if node.children[index]:
                node = node.children[index]
                len += 1
            else: 
                break
        return len