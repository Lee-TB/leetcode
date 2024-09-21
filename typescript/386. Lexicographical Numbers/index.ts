export function lexicalOrder(n: number): number[] {
  const list: number[] = [];
  for (let i = 1; i <= 9; i++) {
    generateLexicalNumbers(i, n, list);
  }
  return list;
}

function generateLexicalNumbers(num: number, limit: number, list: number[]) {
  if (num > limit) return;
  list.push(num);
  for (let i = 0; i <= 9; i++) {
    const computedNum = num * 10 + i;
    if (computedNum <= limit) {
      generateLexicalNumbers(computedNum, limit, list);
    } else break;
  }
}
