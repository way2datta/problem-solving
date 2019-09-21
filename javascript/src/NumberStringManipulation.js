// Given a string str containing alphanumeric characters, calculate sum of all numbers present in the string.
export function sumOfAllNumbersInString(text) {
  var sum = 0;
  var lastNumber = 0;

  for (let index = 0; index < text.length; index++) {
    const char = text[index];

    if (!isNaN(char)) {
      var factor = lastNumber ? 10 : 0;
      lastNumber = lastNumber * factor + +char;
    }
    else {
      sum = sum + lastNumber;
      lastNumber = 0;
    }
  }
  return sum + lastNumber;
}

// Calculate maximum value using ‘+’ or ‘*’ sign between two numbers in a string
export function calculateMaxValue(input) {
  let result = +input[0];

  for (let i = 1; i < input.length; i++) {
    const currentDigit = +input[i];
    if (currentDigit === 0 || currentDigit === 1 ||
      result === 0 || result === 1) {
      result = currentDigit + result;
    }
    else {
      result = currentDigit * result;
    }
  }
  return result;
}
