// Given a string str containing alphanumeric characters, calculate sum of all numbers present in the string.
export function sumOfAllNumbersInString(text) {
  var sum = 0;
  var lastNumber = 0;

  for (let index = 0; index < text.length; index++) {
    const char = text[index];

    if (!isNaN(char)) {
      var factor = lastNumber ? 10  : 0;
      lastNumber = lastNumber * factor + +char;
    }
    else {
      sum = sum + lastNumber;
      lastNumber = 0;
    }
  }
  return sum + lastNumber;
}
