
# Sudoku Solver in C# (Backtracking)

This project implements a Sudoku solver using the **backtracking algorithm**. 
It checks the validity of numbers on a Sudoku board and systematically solves puzzles by filling in numbers step by step.

## Features

- Validates numbers against Sudoku rules (rows, columns, and subgrids).
- Implements a backtracking algorithm to find solutions for any solvable Sudoku puzzle.
- Simple and modular code structure for easy understanding.

## Technology

- **Language**: C#
- **Framework**: .NET Framework 4.7.2
- **IDE**: Visual Studio

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/i-herceg/sudoku-c--backtracking.git
   ```
2. Open the solution file `AUP_sudoku.sln` in Visual Studio.
3. Build the project and run the program.

## How It Works

The algorithm follows these steps:
1. It tries to place a number in an empty cell.
2. It checks if the number is valid using the `jeValjan` method.
3. If valid, it proceeds to the next empty cell.
4. If it encounters a conflict, it backtracks and tries the next possible number.
5. This process continues until the board is solved or no solution exists.

## Example Input/Output

- Input: A partially filled Sudoku board.
- Output: A fully solved Sudoku board.

## File Structure

- `Program.cs`: Contains the main logic for the Sudoku solver.
- `App.config`: Configuration settings for the project.
- `AUP_sudoku.sln`: Visual Studio solution file.

## Author

- **Ivana Herceg**  
  [GitHub Profile](https://github.com/i-herceg)
