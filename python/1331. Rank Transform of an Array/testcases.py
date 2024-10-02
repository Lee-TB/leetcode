import unittest
from parameterized import parameterized
from index import Solution

class SolutionUnitTest(unittest.TestCase):
    def setUp(self):
        self.sln = Solution()

    @parameterized.expand([
        ([40, 10, 20, 30], [4, 1, 2, 3]),
        ([100, 100, 100], [1, 1, 1]),
        ([37, 12, 28, 9, 100, 56, 80, 5, 12], [5, 3, 4, 2, 8, 6, 7, 1, 3])
    ])
    def test_arrayRankTransform_ShouldReturnCorrectRanks(self, arr, expected):
        actual = self.sln.arrayRankTransform(arr)
        self.assertEqual(actual, expected)

if __name__ == '__main__':
    unittest.main()
