export function shortestPalindrome(s: string): string {
  const reversedString = s.split("").reverse().join("");
  for (let i = s.length; i > 0; i--) {
    const prefix = s.substring(0, i);
    const subfixRevesed = reversedString.substring(s.length - i);
    if (prefix === subfixRevesed) {
      const addingString = reversedString.substring(0, s.length - i);
      return addingString + s;
    }
  }
  return "";
}
shortestPalindrome("abcd");
