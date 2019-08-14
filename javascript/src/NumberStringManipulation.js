// Given a string str containing alphanumeric characters, calculate sum of all numbers present in the string.
export function sumOfAllNumbersInString(text) {

  let sum = 0;
  let currentNumber = 0;
  let digitCount = 0;

  for (let index = 0; index < text.length; index++) {
    const char = text.charAt(index);
    if (!isNaN(char)) {
      let factor = digitCount == 0 ? 0 : 10;
      currentNumber = currentNumber * factor + +char;
      digitCount++;
      continue;
    }
    if (currentNumber > 0) {
      sum += currentNumber;
      currentNumber = 0;
      digitCount = 0;
    }
  }
  sum += currentNumber;
  return sum;
}
