import { describe, test, expect } from "bun:test";
import { diffWaysToCompute } from ".";

describe(`diffWaysToCompute()"`, () => {
  test(`Input: expression = "2" => Output: [2]`, () => {
    const expression = "2";
    const output = [2];
    expect(diffWaysToCompute(expression).sort()).toEqual(output.sort());
  });
  test(`Input: expression = "2-1-1" => Output: [0,2]`, () => {
    const expression = "2-1-1";
    const output = [0, 2];
    expect(diffWaysToCompute(expression).sort()).toEqual(output.sort());
  });
  test(`Input: expression = "2*3-4*5" => Output: [-34,-14,-10,-10,10]`, () => {
    const expression = "2*3-4*5";
    const output = [-34, -14, -10, -10, 10];
    expect(diffWaysToCompute(expression).sort()).toEqual(output.sort());
  });
});
