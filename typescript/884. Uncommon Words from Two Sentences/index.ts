export function uncommonFromSentences(s1: string, s2: string): string[] {
  const answer: string[] = [];
  const combined = s1 + " " + s2;
  const words = combined.split(" ");
  const map = new Map<string, number>();

  for (const word of words) {
    const value = map.get(word) ?? 0;
    map.set(word, value + 1);
  }

  for (const [key, value] of map.entries()) {
    if (value === 1) {
      answer.push(key);
    }
  }

  return answer;
}

export function uncommonFromSentences_raw(s1: string, s2: string): string[] {
  const answer: string[] = [];
  const combined = s1 + " " + s2;
  const words = combined.split(" ");
  const map: {
    [key: string]: number;
  } = {};
  for (const word of words) {
    if (!map[word]) {
      map[word] = 1;
    } else {
      map[word] += 1;
    }
  }
  for (const [key, value] of Object.entries(map)) {
    if (value == 1) {
      answer.push(key);
    }
  }
  return answer;
}

const s1 = "this apple is sweet";
const s2 = "this apple is sour";
const start = Bun.nanoseconds();
uncommonFromSentences(s1, s2);
const end = Bun.nanoseconds();
console.log(`Execution time: ${end - start} ns`);
