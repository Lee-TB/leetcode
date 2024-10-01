export function canArrange(arr: number[], k: number): boolean {
  const remainderCount: number[] = Array(k).fill(0);
  arr.forEach((num) => remainderCount[((num % k) + k) % k]++);
  if (remainderCount[0] % 2 !== 0) return false;
  for (let i = 1; i <= Math.floor(k / 2); i++) {
    if (remainderCount[i] != remainderCount[k - i]) return false;
  }
  return true;
}
