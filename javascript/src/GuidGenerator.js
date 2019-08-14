export default {
  generate: (length = 32) => {
    const availableSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    const charactersLength = availableSymbols.length;
    const newSymbols = [];

    for (let index = 0; index < length; index++) {
      const randomNumber = Math.floor(Math.random() * charactersLength);
      const randomChar = availableSymbols.charAt(randomNumber);
      newSymbols.push(randomChar);
    }
    return newSymbols.join("");
  }
};

