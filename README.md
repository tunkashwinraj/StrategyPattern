

# StrategyPattern

## Description

The StrategyPattern project demonstrates the use of the Strategy design pattern to implement various sorting algorithms for a list of `Student` objects. It includes two sorting strategies: ShellSort and QuickSort. The sorting algorithms can be dynamically switched using a `SortContext` class and a `University` context class.

## Features

- **Strategy Pattern Implementation**: Encapsulates different sorting algorithms, allowing easy switching between them.
- **Sorting Algorithms**: Includes ShellSort and QuickSort strategies for sorting a list of students.
- **Context Class**: `SortContext` acts as an abstraction for various sorting strategies.
- **University Class**: A context that manages students and their sorting strategy.

## Project Structure

- **IStrategySort Interface**: Defines the contract for sorting strategies.
- **Student Class**: Represents a student with properties like `FirstName`, `LastName`, `Test1Score`, and `Test2Score`.
- **ShellSortStrategy Class**: Implements the ShellSort algorithm for sorting students.
- **QuickSortStrategy Class**: Implements the QuickSort algorithm for sorting students.
- **SortContext Class**: A context class that applies the selected sorting strategy.
- **University Class**: A class that manages a list of students and their sorting strategy.

## Getting Started

### Prerequisites

- Visual Studio or any C# compatible IDE
- .NET Framework

### Installation

1. Clone the repository or download the ZIP file.
2. Open the project in Visual Studio or any C# compatible IDE.
3. Build and run the application.

### Usage

1. Click the `btnStrategySort` button to test the sorting functionality.
2. Initially, the list of students will be sorted using the ShellSort strategy.
3. Afterward, the sorting strategy can be switched to QuickSort and the list will be re-sorted.

### Example

```csharp
// Adding students to the University
University u1 = new University(new ShellSortStrategy());
u1.AddStudent(new Student { FirstName = "Bill", LastName = "Baker", Id = 12345, Test1Score = 85, Test2Score = 91 });
u1.AddStudent(new Student { FirstName = "Sally", LastName = "Mathews", Id = 12348, Test1Score = 87, Test2Score = 93 });
u1.AddStudent(new Student { FirstName = "Adam", LastName = "Fredericks", Id = 12341, Test1Score = 82, Test2Score = 83 });

// Sorting students using ShellSort
u1.SortStudent();

// Switching sorting strategy to QuickSort
u1.SortStrategy = new QuickSortStrategy();
u1.SortStudent();
```

### Output

The application displays sorted student lists first using ShellSort, followed by QuickSort.

## Contributing

Feel free to fork this repository, create a branch, and submit a pull request if you'd like to contribute. Any improvements or new sorting strategies are welcome!



