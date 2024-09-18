import unittest
from index import Solution

sln = Solution()

class Testcases(unittest.TestCase):

    def test_1(self):
        nums = [10, 2]
        output = "210"
        self.assertEqual(sln.largestNumber(nums), output)

    def test_2(self):
        nums = [3,30,34,5,9]
        output = "9534330"
        self.assertEqual(sln.largestNumber(nums), output)

if __name__ == '__main__':
    unittest.main()