import { describe, test, expect } from "bun:test";
import { arrayRankTransform } from ".";

describe("arrayRankTransform()", () => {
  test.each([
    { arr: [40, 10, 20, 30], expected: [4, 1, 2, 3] },
    { arr: [100, 100, 100], expected: [1, 1, 1] },
    {
      arr: [37, 12, 28, 9, 100, 56, 80, 5, 12],
      expected: [5, 3, 4, 2, 8, 6, 7, 1, 3],
    },
  ])("ShouldReturnCorrectRanks", ({ arr, expected }) => {
    // Act
    const actual = arrayRankTransform(arr);
    // Assert
    expect(actual).toEqual(expected);
  });
});
