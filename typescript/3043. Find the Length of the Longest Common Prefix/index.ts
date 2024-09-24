export function longestCommonPrefix(arr1: number[], arr2: number[]): number {
  let maxLen = 0;
  const set = new Set();

  for (const num of arr1) {
    let subnum = num;
    while (subnum > 0) {
      set.add(subnum);
      subnum = Math.floor(subnum / 10);
    }
  }

  for (const num of arr2) {
    let subnum = num;
    while (subnum > 0) {
      if (set.has(subnum)) {
        maxLen = Math.max(maxLen, subnum.toString().length);
        break;
      }
      subnum = Math.floor(subnum / 10);
    }
  }

  return maxLen;
}

export function longestCommonPrefix_Trie(
  arr1: number[],
  arr2: number[]
): number {
  let maxLen = 0;
  const trie: Trie = new Trie();
  for (const num of arr1) {
    trie.insert(num);
  }

  for (const num of arr2) {
    const len = trie.findLongestPrefix(num);
    maxLen = Math.max(maxLen, len);
  }

  return maxLen;
}

class TrieNode {
  public children: TrieNode[];
  constructor() {
    this.children = Array(10).fill(null);
  }
}

class Trie {
  private root: TrieNode;
  constructor() {
    this.root = new TrieNode();
  }

  public insert(num: number): void {
    let node: TrieNode = this.root;
    const numStr = num.toString();
    for (const digit of numStr) {
      const index = parseInt(digit);
      if (node.children[index] == null) {
        node.children[index] = new TrieNode();
      }
      node = node.children[index];
    }
  }

  public findLongestPrefix(num: number): number {
    let len: number = 0;
    let node: TrieNode = this.root;
    const numStr = num.toString();
    for (const digit of numStr) {
      const index = parseInt(digit);
      if (node.children[index] != null) {
        len++;
        node = node.children[index];
      } else break;
    }
    return len;
  }
}
