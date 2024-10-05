import unittest
from index import Solution
from parameterized import parameterized

class SolutionUnitTest(unittest.TestCase):
    def setUp(self):
        self.sln = Solution()

    @parameterized.expand([
        ( "abc",  "pqr",  "apbqcr" ),
        ( "ab",  "pqrs",  "apbqrs" ),
        ( "abcd",  "pq",  "apbqcd" ),
    ])
    def test_mergeAlternately_ShouldReturnCorrectMergedString(self, word1, word2, expected):
        merged = self.sln.mergeAlternately(word1, word2)
        self.assertEqual(merged, expected)

if __name__ == '__main__':
    unittest.main()