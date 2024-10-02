export function arrayRankTransform(arr: number[]): number[] {
  const sortedArr = [...new Set(arr)].sort((a, b) => a - b);
  const rankMap = new Map<number, number>();
  sortedArr.forEach((num) => {
    rankMap.set(num, rankMap.size + 1);
  });
  return arr.map((num) => rankMap.get(num) as number);
}
