export default class Array {
  static contains(collection, searchElements) {
    let numberOfElementsFound = 0;

    for (let i = 0; i < collection.length; i++) {
      if (numberOfElementsFound === searchElements.length) {
        break;
      }
      numberOfElementsFound = 0;
      for (let j = 0; j < searchElements.length; j++) {
        if (searchElements[j] === collection[i]) {
          i++;
          numberOfElementsFound++;
          continue;
        }
        if(numberOfElementsFound>0) {
          i--;
        }
        break;
      }
    }
    return numberOfElementsFound > 0;
  }
}
