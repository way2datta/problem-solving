var Stack = (function (initialCapacity = 5) {
  const capacity = initialCapacity;
  const elements = [];
  let stackPointer = 0;

  const push = (element) => {
    if (stackPointer === capacity) {
      throw new Error("Stack is full");
    }
    elements.push(element);
    stackPointer++;
  };
  const pop = () => {
    if (stackPointer === 0) {
      throw new Error("Stack is empty");
    }
    stackPointer--;
    return elements.pop();
  };
  const peek = () => {
    return elements[stackPointer - 1];
  };
  return {
    push: push,
    pop: pop,
    peek: peek
  };
});

var numberStack = Stack(3);
numberStack.push(1);
numberStack.push(2);
numberStack.push(3);
console.log(numberStack.peek());
//numberStack.push(4);


