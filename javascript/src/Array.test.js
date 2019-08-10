import { expect } from "chai";
import Array from "./Array";
describe.only("Array", () => {
  describe("#contains", () => {
    it("should return true if search elements are present in the middle  of the given array", () => {
      // Arrange
      const numbers = [1, 2, 3, 3, 4, 5];
      const subset = [3, 4];

      // Act
      const containsSubset = Array.contains(numbers, subset);

      // Assert
      expect(containsSubset).to.be.true;
    });

    it("should return true if search elements are present at the beginning of the given array", () => {
      // Arrange
      const numbers = [1, 2, 2, 3, 4, 5];
      const searchElements = [1, 2];

      // Act
      const containsSearchElements = Array.contains(numbers, searchElements);

      // Assert
      expect(containsSearchElements).to.be.true;
    });

    it("should return true if search elements are present at the end of the given array", () => {
      // Arrange
      const numbers = [1, 2, 3, 4, 4, 5];
      const searchElements = [4, 5];

      // Act
      const containsSearchElements = Array.contains(numbers, searchElements);

      // Assert
      expect(containsSearchElements).to.be.true;
    });

    it("should return false if search elements are not present in the given array", () => {
      // Arrange
      const numbers = [1, 2, 3, 4, 4, 5];
      const searchElements = [3, 4, 5];

      // Act
      const containsSearchElements = Array.contains(numbers, searchElements);

      // Assert
      expect(containsSearchElements).to.be.false;
    });
  });
});
