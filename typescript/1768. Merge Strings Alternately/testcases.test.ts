import { expect, describe, test } from "bun:test";
import { mergeAlternately } from ".";

describe("mergeAlternately()", () => {
  test.each([
    { word1: "abc", word2: "pqr", expected: "apbqcr" },
    { word1: "ab", word2: "pqrs", expected: "apbqrs" },
    { word1: "abcd", word2: "pq", expected: "apbqcd" },
  ])("ShouldReturnCorrectValue", ({ word1, word2, expected }) => {
    const merged = mergeAlternately(word1, word2);
    expect(merged).toBe(expected);
  });
});
