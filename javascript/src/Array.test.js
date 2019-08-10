import { expect } from "chai";
describe.only('Array', () => {
  describe("#contains", () => {
    it("should return true if array to be searched is present in the given array", () => {
      // Arrange
      const numbers = [1, 2, 3, 4, 5];
      const subset = [3, 4];

      // Act
      const containsSubset = Array.contains(numbers, subset)

      // Assert
      expect(containsSubset).to.be.equal(true);
    })
  })
})
