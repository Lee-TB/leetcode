import unittest
from index import Solution, Solution2

sln = Solution()
sln2 = Solution2()

class Testcases(unittest.TestCase):

    def test_1(self):
        arr1 = [1,10,100]
        arr2 = [1000]
        expected = 3
        actual = sln.longestCommonPrefix(arr1, arr2)
        self.assertEqual(actual, expected)

    def test_2(self):
        arr1 = [1,2,3]
        arr2 = [4,4,4]
        expected = 0
        actual = sln.longestCommonPrefix(arr1, arr2)
        self.assertEqual(actual, expected)

    def test_3(self):
        arr1 = [10]
        arr2 = [17, 11]
        expected = 1
        actual = sln.longestCommonPrefix(arr1, arr2)
        self.assertEqual(actual, expected)

class Testcases2(unittest.TestCase):
    def test_1(self):
        arr1 = [1,10,100]
        arr2 = [1000]
        expected = 3
        actual = sln2.longestCommonPrefix(arr1, arr2)
        self.assertEqual(actual, expected)

    def test_2(self):
        arr1 = [1,2,3]
        arr2 = [4,4,4]
        expected = 0
        actual = sln2.longestCommonPrefix(arr1, arr2)
        self.assertEqual(actual, expected)

    def test_3(self):
        arr1 = [10]
        arr2 = [17, 11]
        expected = 1
        actual = sln2.longestCommonPrefix(arr1, arr2)
        self.assertEqual(actual, expected)

if __name__ == '__main__':
    unittest.main()