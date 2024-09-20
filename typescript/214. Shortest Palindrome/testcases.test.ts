import { describe, test, expect } from "bun:test";
import { shortestPalindrome } from ".";

describe(`shortestPalindrome()"`, () => {
  test(`Input: s = "aacecaaa" => Output: "aaacecaaa"`, () => {
    const s = "aacecaaa";
    const output = "aaacecaaa";
    expect(shortestPalindrome(s)).toEqual(output);
  });
  test(`Input: s = "abcd" => Output: "dcbabcd"`, () => {
    const s = "abcd";
    const output = "dcbabcd";
    expect(shortestPalindrome(s)).toEqual(output);
  });
});
