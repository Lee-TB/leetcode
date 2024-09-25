import { describe, test, expect } from "bun:test";
import { sumPrefixScores } from ".";

describe(`sumPrefixScores()"`, () => {
  test(`should return empty array when words is an empty array`, () => {
    // Arrange
    const words: string[] = [];
    const expected: number[] = [];

    // Act
    const actual = sumPrefixScores(words);

    // Assert
    expect(actual).toEqual(expected);
  });

  test(`should return correct prefix scores for a valid input`, () => {
    // Arrange
    const words: string[] = ["abc", "ab", "bc", "b"];
    const expected: number[] = [5, 4, 3, 2];

    // Act
    const actual = sumPrefixScores(words);

    // Assert
    expect(actual).toEqual(expected);
  });

  test(`should return correct prefix scores for a valid input`, () => {
    // Arrange
    const words: string[] = ["abcd"];
    const expected: number[] = [4];

    // Act
    const actual = sumPrefixScores(words);

    // Assert
    expect(actual).toEqual(expected);
  });
});
