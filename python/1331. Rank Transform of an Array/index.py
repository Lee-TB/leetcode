from typing import List, Dict
class Solution:
    def arrayRankTransform(self, arr: List[int]) -> List[int]:
        sortedDistinctList: List[int] = sorted(set(arr))
        rankMap = {num: i + 1 for i, num in enumerate(sortedDistinctList)}
        return [rankMap[num] for num in arr]
    
    def arrayRankTransform2(self, arr: List[int]) -> List[int]:
        return list(map({num: i + 1 for i, num in enumerate(sorted(set(arr)))}.get, arr))
    
sln = Solution()
print(sln.arrayRankTransform([37, 12, 28, 9, 100, 56, 80, 5, 12]))