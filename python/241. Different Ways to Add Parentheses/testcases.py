import unittest
from index import Solution

sln = Solution()

class Testcases(unittest.TestCase):

    def test_1(self):
        expression = "2-1-1"
        output = [0,2]
        self.assertEqual(sorted(sln.diffWaysToCompute(expression)), sorted(output))
        
    def test_2(self):
        expression = "2*3-4*5"
        output = [-34,-14,-10,-10,10]
        self.assertEqual(sorted(sln.diffWaysToCompute(expression)), sorted(output))

if __name__ == '__main__':
    unittest.main()