export default class String {
  static contains(value, searchText) {
    var charMatchedCount;
    for (let valueIndex = 0; valueIndex < value.length; valueIndex++) {
      if (charMatchedCount === searchText.length) {
        break;
      }
      charMatchedCount = 0;
      for (let searchIndex = 0; searchIndex < searchText.length; searchIndex++) {
        const searchChar = searchText[searchIndex];
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
