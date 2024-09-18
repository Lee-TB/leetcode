import { describe, test, expect } from "bun:test";
import { largestNumber } from ".";

describe(`largestNumber()"`, () => {
  test(`Input: nums = [10,2] => Output: "210"`, () => {
    const nums = [10, 2];
    const output = "210";
    expect(largestNumber(nums)).toEqual(output);
  });
  test(`Input: nums = [3,30,34,5,9] => Output: "9534330"`, () => {
    const nums = [3, 30, 34, 5, 9];
    const output = "9534330";
    expect(largestNumber(nums)).toEqual(output);
  });
});
