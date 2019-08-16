export default class String {
  static contains(value, searchText) {
    var numberOfLettersMatched;
    for (let valueIndex = 0; valueIndex < value.length; valueIndex++) {
      const containsSearchText = numberOfLettersMatched === searchText.length;
      if (containsSearchText) {
        break;
      }
      numberOfLettersMatched = 0;
      for (let searchIndex = 0; searchIndex < searchText.length; searchIndex++) {
        const searchChar = searchText[searchIndex];
        if (searchChar === value[valueIndex]) {
          valueIndex++;
          numberOfLettersMatched++;
          continue;
        }
        if (numberOfLettersMatched) {
          valueIndex--;
        }
        break;
      }
    }
    return numberOfLettersMatched > 0;
  }

  static trimStart(value) {
    const length = value.length;
    var spaceCount = 0;
    while (spaceCount < length) {
      if (value.charCodeAt(spaceCount) === 32) {
        spaceCount++;
        continue;
      }
      break;
    }
    return value.substring(spaceCount);
  }
}
