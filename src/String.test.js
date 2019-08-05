import { expect } from "chai";
import String from "./String";

describe("String", () => {
  describe("#contains()", () => {
    it("should return true when search string is present in given string", () => {
      // Arrange
      var value ="In the future, Earth is slowly becoming uninhabitable. Ex-NASA pilot Cooper, along with a team of researchers, is sent on a planet exploration mission to report which planet can sustain life."

      // Act
     var containsSearchString = String.contains(value, "become");

     // Assert
     expect(containsSearchString).to.be.true;
    });
  });
});
