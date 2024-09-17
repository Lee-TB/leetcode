import { describe, test, expect } from "bun:test";
import { uncommonFromSentences } from ".";

describe(`uncommonFromSentences"`, () => {
  test(`Input: s1 = "this apple is sweet", s2 = "this apple is sour" => Output: ["sweet","sour"]`, () => {
    const s1 = "this apple is sweet";
    const s2 = "this apple is sour";
    const output = ["sweet", "sour"];
    expect(uncommonFromSentences(s1, s2)).toEqual(output);
  });
  test(`Input: s1 = "apple apple", s2 = "banana" => Output: ["banana"]`, () => {
    const s1 = "apple apple";
    const s2 = "banana";
    const output = ["banana"];
    expect(uncommonFromSentences(s1, s2)).toEqual(output);
  });
});
