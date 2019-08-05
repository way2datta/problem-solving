export default class String {
  static contains(value, searchString) {
    var charMatchedCount;
    for (let valueIndex = 0; valueIndex < value.length; valueIndex++) {
      if (charMatchedCount === searchString.length) {
        break;
      }
      charMatchedCount = 0;
      for (let searchIndex = 0; searchIndex < searchString.length; searchIndex++) {
        const searchChar = searchString[searchIndex];
        if (searchChar === value[valueIndex]) {
          valueIndex++;
          charMatchedCount++;
          continue;
        }
        break;
      }
    }
    return charMatchedCount > 0;
  }
}
