function Node(value, nextNode) {
  this.value = value;
  this.next = nextNode;
}

module.exports = {
  head: undefined,
  add: (value) => {
    const newNode = new Node(value);
    if (!this.head) {
      this.head = newNode;
      return;
    }
    let currentNode = this.head;
    while (currentNode.next) {
      currentNode = currentNode.next;
    }
    currentNode.next = newNode;
  },
  addFirst: (value) =>{
    const newNode = new Node(value);
    newNode.next = this.head;
    this.head = newNode;
  },
  iterate: () => {
    let currentNode = this.head;
    while (currentNode) {
      console.log(currentNode.value);
      currentNode = currentNode.next;
    }
  },
  remove: (value) => {
    if(!this.head) {
      return;
    }
    if (this.head.value == value) {
      this.head = this.head.next;
      return;
    }

    let currentNode = this.head;
    let previousNode = this.head;

    while (currentNode.value != value) {
      previousNode = currentNode;
      currentNode = currentNode.next;
    }
    previousNode.next = currentNode.next;
  }
};
