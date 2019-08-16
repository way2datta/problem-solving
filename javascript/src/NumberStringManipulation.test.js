import { expect } from "chai";
import { sumOfAllNumbersInString, calculateMaxValue } from "./NumberStringManipulation";

describe("sumOfAllNumbersInString", () => {
  it("should return 3 when string is '1abc2d'", () => {
    // Arrange
    const inputText = "1abc2d";

    // Act
    const sum = sumOfAllNumbersInString(inputText);

    // Assert
    expect(sum).to.be.equal(3);
  });

  it("should return 100 when string is '1abc23d'", () => {
    // Arrange
    const inputText = "1abc23d";

    // Act
    const sum = sumOfAllNumbersInString(inputText);

    // Assert
    expect(sum).to.be.equal(24);
  });

  it("should return 61 when string is '1abc23d476z'", () => {
    // Arrange
    const inputText = "1abc23d476z";

    // Act
    const sum = sumOfAllNumbersInString(inputText);

    // Assert
    expect(sum).to.be.equal(500);
  });

  it("should return 61 when string is '1abc23d576'", () => {
    // Arrange
    const inputText = "1abc23d576";

    // Act
    const sum = sumOfAllNumbersInString(inputText);

    // Assert
    expect(sum).to.be.equal(600);
  });
});

describe.only("calculateMaxValue", ()=>{
  it("should return 73 for input 891", ()=>{
    // Arrange
    const input = "891";

    // Act
    const result = calculateMaxValue(input);

    // Assert
    expect(result).to.be.equal(73);
  });

  it("should return 10 for input 01231", ()=>{
    // Arrange
    const input = "01231";

    // Act
    const result = calculateMaxValue(input);

    // Assert
    expect(result).to.be.equal(10);
  });
});
