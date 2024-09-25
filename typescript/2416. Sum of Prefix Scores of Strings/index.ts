export function sumPrefixScores(words: string[]): number[] {
  const trie: Trie = new Trie();
  for (const word of words) {
    trie.insert(word);
  }

  const scores: number[] = [];
  for (const word of words) {
    scores.push(trie.countPrefix(word));
  }
  return scores;
}

class Trie {
  private root: TrieNode;
  constructor() {
    this.root = new TrieNode();
  }

  public insert(word: string) {
    let node: TrieNode = this.root;
    for (const char of word) {
      const index = char.charCodeAt(0) - "a".charCodeAt(0);
      if (!node.children.has(index)) {
        node.children.set(index, new TrieNode());
      }
      const childNode = node.children.get(index) as TrieNode;
      childNode.count++;
      node = childNode;
    }
  }

  public countPrefix(word: string): number {
    let node: TrieNode = this.root;
    let count: number = 0;
    for (const char of word) {
      const index = char.charCodeAt(0) - "a".charCodeAt(0);
      if (node.children.has(index)) {
        const childNode = node.children.get(index) as TrieNode;
        count += childNode.count;
        node = childNode;
      } else break;
    }
    return count;
  }
}

class TrieNode {
  public children: Map<number, TrieNode>;
  public count: number;

  constructor() {
    this.children = new Map<number, TrieNode>();
    this.count = 0;
  }
}
