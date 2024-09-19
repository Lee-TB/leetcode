from typing import List

class Solution:
    def diffWaysToCompute(self, expression: str) -> List[int]:
        if(expression.isdigit()):
            return [int(expression)]
        res = []
        for i in range(0, len(expression)):
            cur_char = expression[i]
            if(cur_char in "+-*"):
                left = self.diffWaysToCompute(expression[:i])
                right = self.diffWaysToCompute(expression[i+1:])
                for l in left:
                    for r in right:
                        if(cur_char == '+'):
                            res.append(l + r)
                        elif(cur_char == '-'):
                            res.append(l - r)
                        elif(cur_char == '*'):
                            res.append(l * r)
        return res
            
