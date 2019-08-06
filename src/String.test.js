import { expect } from "chai";
import String from "./String";

describe("String", () => {
  describe("#contains()", () => {
    it("should return true when search string is present in given string", () => {
      // Arrange
      var value ="DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "KA");

      // Assert
      expect(containsSearchString).to.be.true;
    });

    it("should return true when search string is present at the begining", () => {
      // Arrange
      var value ="DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "DA");

      // Assert
      expect(containsSearchString).to.be.true;
    });

    it("should return true when search string is present in the end", () => {
      // Arrange
      var value ="DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "LE");

      // Assert
      expect(containsSearchString).to.be.true;
    });
  });
});
