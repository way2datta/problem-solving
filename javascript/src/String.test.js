import { expect } from "chai";
import String from "./String";

describe("String", () => {
  describe("#contains()", () => {
    it("should return true when search string is present in given string", () => {
      // Arrange
      var value = "DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "KA");

      // Assert
      expect(containsSearchString).to.be.true;
    });

    it("should return true when search string is present at the begining", () => {
      // Arrange
      var value = "DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "DA");

      // Assert
      expect(containsSearchString).to.be.true;
    });

    it("should return true when search string is present in the end", () => {
      // Arrange
      var value = "DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "LE");

      // Assert
      expect(containsSearchString).to.be.true;
    });

    it("should return false when search string is not present", () => {
      // Arrange
      var value = "DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "BH");

      // Assert
      expect(containsSearchString).to.be.false;
    });

  });
  describe("#trimStart()", () => {
    it.only("should trim string from the begining", () => {
      // Arrange
      var value = "        DATTATRAYA KALE";

      // Act
      var trimedValue = String.trimStart(value);

      // Assert
      expect(trimedValue).to.be.equal("DATTATRAYA KALE");
    });
  });
});
