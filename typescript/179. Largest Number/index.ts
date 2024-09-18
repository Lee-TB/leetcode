export function largestNumber(nums: number[]): string {
  const numStrings = nums.map(String);
  numStrings.sort((a, b) => (b + a).localeCompare(a + b));
  if (numStrings[0] === "0") return "0";
  return numStrings.join("");
}
const nums = [3, 30, 34, 5, 9];
largestNumber(nums);
