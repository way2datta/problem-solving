export default class String {
  static contains(value, searchText) {
    var charMatchedCount;
    for (let valueIndex = 0; valueIndex < value.length; valueIndex++) {
      const containsSearchText = charMatchedCount === searchText.length;
      if (containsSearchText) {
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
        if(charMatchedCount) {
          valueIndex--;
        }
        break;
      }
    }
    return charMatchedCount > 0;
  }
}
