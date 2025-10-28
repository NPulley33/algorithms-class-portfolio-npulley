# About: this is a class portfolio for PROG 366 (Algorithms) at Columbia College Chicago

## Directory:

### Hanoi Tower:
- Custom Linked List, Stack, and Queue implementation
- Basic Hanoi Tower game made with custom data structures
- Dumb auto-solver for hanoi game

### Karl Teaching: 
- BigO:
  - O(1) Constant time: Accessing the first element of an array. One step, constant time.
  - O(n) Find number of occurances: takes an array and a value, traverses through the entire array of length n to find how many times the value occurs in the array. Time is dependent on the size of the array.
  - O(n^2) Find number of occurances in a 2D array: takes same parameters, but searches a 2D array, worst case of length n & width n. Time is dependent on length/width of 2D array. 
- FisherYates Shuffle: iterates through an array from end to beginning & randomly swaps elements from the beginning to the current point. 
- LeetCode solutions: a collection of solutions to various LeetCode problems
- other bits & bobs

### Data Structure Comparison
- Maps vs. Arrays:
  - a map is an array of buckets that uses a hash or other algorithm to determine where an element would be placed. This makes finding any particular element very fast as you know exactly where to access it.
  - Arrays store items linerally, and to find an element you have to traverse through the array.
  - Maps are useful when you need to worry about space and accessing elements quickly. Arrays are useful when you need to traverse through all of the elements. 
- Stacks vs. Queues:
  - a stack is a first in, last out (FILO) collection.
  - a queue is a first in, first out (FIFO) collection.
  - With both collections, you can only access the "top" or "first" element. Determining which to use is based off of what order you need to access elements in. 
