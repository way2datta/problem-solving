import { assert, expect } from "chai";

import WikiPostParser from "./WikiPostParser";

describe("WikiPostParser", () => {
  describe("#parse", () => {
    it("should return wiki post", () => {
      // Arrange
      const text = `Short summary of post
                    First question?
                    Second question?
                    Third question?
                    Fourth question?
                    Fifth question?
                    Fifth possible answer;First possible answer;Fourth possible answer;Second one; Third`;

      // Act
      const post = WikiPostParser.parse(text);

      // Assert
      assert.exists(post.content);
      assert.exists(post.questions);
      assert.exists(post.possibleAnswers);
    });

    it("should parse summary", () => {
      // Arrange
      const text = `Short summary of post
                    First question?
                    Second question?
                    Third question?
                    Fourth question?
                    Fifth question?
                    Fifth possible answer;First possible answer;Fourth possible answer;Second one; Third`;

      // Act
      const post = WikiPostParser.parse(text);

      // Assert
      expect(post.content).to.be.equal("Short summary of post");
    });

    it("should parse questions", () => {
      // Arrange
      const text = `Short summary of post
First question?
Second question?
Third question?
Fourth question?
Fifth question?
                    Fifth possible answer;First possible answer;Fourth possible answer;Second one; Third`;

      // Act
      const post = WikiPostParser.parse(text);

      // Assert
      expect(post.questions).to.deep.equal([
        'First question?',
          'Second question?',
          'Third question?',
          'Fourth question?',
          'Fifth question?'
      ]);
    });

    it("should parse possible answers", () => {
      // Arrange
      const text = `Short summary of post
                    First question?
                    Second question?
                    Third question?
                    Fourth question?
                    Fifth question?
Fifth possible answer;First possible answer;Fourth possible answer;Second one; Third`;

      // Act
      const post = WikiPostParser.parse(text);

      // Assert
      expect(post.possibleAnswers).to.deep.equal([
        'Fifth possible answer',
        'First possible answer',
        'Fourth possible answer',
        'Second one',
        ' Third'
      ]);
    });
  });
});
