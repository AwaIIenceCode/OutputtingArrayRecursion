# RecursiveArrayTask

A C# console application that demonstrates recursion by generating and printing an array of random integers.

## How to Run
1. Clone the repository: `git clone https://github.com/AwaIIenceCode/OutputtingArrayRecursion.git`
2. Open in Visual Studio or Rider.
3. Build and run the project.
4. Observe the console output displaying a randomly generated array of 15 integers.

## Features
- Uses a recursive `Generaterray` method to populate an array with random integers between -11 and 11.
- Implements a recursive `PrintArray` method to display array elements.
- Array size is fixed at 15 elements.
- Utilizes `Random` class for generating values.

## About
This project is a learning exercise to explore recursion in C#. It shows how recursive functions can replace loops for tasks like array initialization and printing, enhancing understanding of recursive logic.

## Notes
- The array is generated and printed using recursion, which may not be optimal for large sizes due to stack overflow risks.
- Current implementation uses a fixed size of 15; consider adjusting for larger datasets with caution.
