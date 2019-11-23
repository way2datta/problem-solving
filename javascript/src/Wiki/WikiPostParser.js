
const LINE_SEPARATOR = "\n";
const ANSWER_SEPARATOR = ";";

export default class WikiPostParser {
  static parse(text) {
    const parts = text.split(LINE_SEPARATOR);
    const content = parts[0];
    const questions = WikiPostParser.parseQuestions(parts);
    const possibleAnswers = WikiPostParser.parsePossibleAnswers(parts);
    return {
      content, questions, possibleAnswers
    };
  }

  static parsePossibleAnswers(parts) {
    return parts[6].split(ANSWER_SEPARATOR);
  }

  static parseQuestions(parts) {
    const questions = [];
    for (let index = 1; index <= 5; index++) {
      const question = parts[index];
      questions.push(question);
    }
    return questions;
  }
}
