import { describe, test, expect } from "bun:test";
import { canArrange } from ".";

// Unit tests
describe("Solution Unit Test", () => {
  test.each([
    { arr: [1, 2, 3, 4, 5, 10, 6, 7, 8, 9], k: 5 },
    { arr: [1, 2, 3, 4, 5, 6], k: 7 },
  ])("CanArrange_ShouldReturnTrue", ({ arr, k }) => {
    const actual = canArrange(arr, k);
    expect(actual).toBe(true);
  });

  test("CanNotArrange_ShouldReturnFalse", () => {
    const arr = [1, 2, 3, 4, 5, 6];
    const k = 10;

    const actual = canArrange(arr, k);
    expect(actual).toBe(false);
  });
});
