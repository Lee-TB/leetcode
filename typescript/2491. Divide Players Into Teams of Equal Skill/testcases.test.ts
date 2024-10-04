import { describe, test, expect } from "bun:test";
import { dividePlayers } from ".";

describe("dividePlayers()", () => {
  test.each([
    { skill: [2, 2, 2, 2], expected: 8 },
    { skill: [3, 2, 5, 1, 3, 4], expected: 22 },
    { skill: [3, 4], expected: 12 },
    { skill: [1, 1, 2, 3], expected: -1 },
  ])("ShouldReturnCorrectValue", ({ skill, expected }) => {
    const actual: number = dividePlayers(skill);
    expect(actual).toBe(expected);
  });
});
