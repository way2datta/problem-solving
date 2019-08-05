import { expect } from "chai";
import String from "./String";

describe("String", () => {
  describe("#contains()", () => {
    it("should return true when search string is present in given string", () => {
      // Arrange
      var value ="DATTATRAYA KALE";

      // Act
      var containsSearchString = String.contains(value, "TRAY");

      // Assert
      expect(containsSearchString).to.be.true;
    });
  });
});
