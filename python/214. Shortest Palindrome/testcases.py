import unittest
from index import Solution

sln = Solution()

class Testcases(unittest.TestCase):
    def test_0(self):
        s = "aba"
        output = "aba"
        self.assertEqual(sln.shortestPalindrome(s), output)

    def test_1(self):
        s = "aacecaaa"
        output = "aaacecaaa"
        self.assertEqual(sln.shortestPalindrome(s), output)

    def test_2(self):
        s = "abcd"
        output = "dcbabcd"
        self.assertEqual(sln.shortestPalindrome(s), output)

if __name__ == '__main__':
    unittest.main()