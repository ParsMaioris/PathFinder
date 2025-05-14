## Overview

One Way Streets is a C# solution that demonstrates finding the shortest path in a weighted directed acyclic graph (DAG). Inspired by the simplicity of one-way streets, this project breaks down a complex problem into clear, manageable subproblems using DFS-based topological sorting and dynamic programming.

## Project Overview

- **Problem:** Compute the least costly path from a starting intersection (node 1) to a destination (node 6) in a weighted DAG.
- **Approach:**  
  - Use DFS for a topological sort.
  - Apply dynamic programming in reverse topological order.
- **Environment:** .NET 9, MSTest

## Repository Structure

- **src/**
  - **Edge.cs:** Defines a simple, immutable edge between nodes.
  - **Graph.cs:** Implements the DAG, topological sort, and shortest path algorithm.
  - **GraphTests.cs:** Contains MSTest tests to validate the solution.
- **OneWayStreets_Blueprint.pdf:** An eight-page blueprint detailing the problem and solution.

## Getting Started

1. **Clone the Repository:**  
   `git clone <repository_url>`

2. **Open the Project:**  
   You can work with your preferred development environment. For example:
   - **Visual Studio:** Open the solution file.
   - **Visual Studio Code:** Launch the project by running `code .` from the repository folder.
   - **.NET CLI:** Use your terminal or favorite editor.

3. **Build and Test:**  
   - Restore packages: `dotnet restore`
   - Build the project: `dotnet build`
   - Run tests: `dotnet test`

## Debugging

If you want to debug the application, here’s how you can get started:

- **Visual Studio:**  
  Open the solution, set breakpoints in your code, and run in Debug mode. The integrated debugger will let you step through your code.

- **Visual Studio Code:**  
  Ensure you have the C# extension installed. Configure your launch settings in a `launch.json` file (usually auto-generated when you first start debugging). Hit F5 to start debugging, and use breakpoints as needed.

- **.NET CLI:**  
  You can run the application with debugging enabled using commands like `dotnet run --launch-profile "YourProfile"` if you have a configured launch profile, or attach a debugger to the running process.

## Contact

For questions or further discussion, please open an issue or reach out directly.