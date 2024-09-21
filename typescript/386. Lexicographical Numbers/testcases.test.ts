import { describe, test, expect } from "bun:test";
import { lexicalOrder } from ".";

describe(`lexicalOrder()"`, () => {
  test(`Input: s1 = "this apple is sweet", s2 = "this apple is sour" => Output: ["sweet","sour"]`, () => {
    const n = 13;
    const output = [1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9];
    expect(lexicalOrder(n)).toEqual(output);
  });
  test(`Input: s1 = "this apple is sweet", s2 = "this apple is sour" => Output: ["sweet","sour"]`, () => {
    const n = 2;
    const output = [1, 2];
    expect(lexicalOrder(n)).toEqual(output);
  });
});
