import { describe, test, expect } from "bun:test";
import { longestCommonPrefix, longestCommonPrefix_Trie } from ".";

describe(`longestCommonPrefix()"`, () => {
  test(`Input: arr1 = [1,10,100], arr2 = [1000] => Output: 3`, () => {
    const arr1 = [1, 10, 100],
      arr2 = [1000];
    const expected = 3;
    const actual = longestCommonPrefix(arr1, arr2);
    expect(actual).toEqual(expected);
  });

  test(`Input: arr1 = [1,2,3], arr2 = [4,4,4] => Output: 0`, () => {
    const arr1 = [1, 2, 3],
      arr2 = [4, 4, 4];
    const expected = 0;
    const actual = longestCommonPrefix(arr1, arr2);
    expect(actual).toEqual(expected);
  });

  test(`Input: arr1 = [10], arr2 = [17, 11] => Output: 0`, () => {
    const arr1 = [10],
      arr2 = [17, 11];
    const expected = 1;
    const actual = longestCommonPrefix(arr1, arr2);
    expect(actual).toEqual(expected);
  });
});

describe(`longestCommonPrefix_Trie()"`, () => {
  test(`Input: arr1 = [1,10,100], arr2 = [1000] => Output: 3`, () => {
    const arr1 = [1, 10, 100],
      arr2 = [1000];
    const expected = 3;
    const actual = longestCommonPrefix_Trie(arr1, arr2);
    expect(actual).toEqual(expected);
  });

  test(`Input: arr1 = [1,2,3], arr2 = [4,4,4] => Output: 0`, () => {
    const arr1 = [1, 2, 3],
      arr2 = [4, 4, 4];
    const expected = 0;
    const actual = longestCommonPrefix_Trie(arr1, arr2);
    expect(actual).toEqual(expected);
  });

  test(`Input: arr1 = [10], arr2 = [17, 11] => Output: 0`, () => {
    const arr1 = [10],
      arr2 = [17, 11];
    const expected = 1;
    const actual = longestCommonPrefix_Trie(arr1, arr2);
    expect(actual).toEqual(expected);
  });
});
