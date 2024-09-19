export function diffWaysToCompute(expression: string): number[] {
  if (expression.length === 0) return [];

  if (isDigit(expression)) {
    return [parseInt(expression)];
  }

  const result: number[] = [];

  for (let i = 0; i < expression.length; i++) {
    const currentChar = expression[i];
    if (isDigit(currentChar)) continue;
    const leftResult = diffWaysToCompute(expression.substring(0, i));
    const rightResult = diffWaysToCompute(expression.substring(i + 1));
    for (const leftVal of leftResult) {
      for (const rightVal of rightResult) {
        let computed = 0;
        if (currentChar === "+") {
          computed = leftVal + rightVal;
        } else if (currentChar === "-") {
          computed = leftVal - rightVal;
        } else if (currentChar === "*") {
          computed = leftVal * rightVal;
        }
        result.push(computed);
      }
    }
  }

  return result;
}

function isDigit(str: string) {
  return /^\d+$/.test(str);
}

const res = diffWaysToCompute("2*3-4*5");
console.log(res);
