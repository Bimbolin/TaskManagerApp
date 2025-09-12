# Task Manager Console App

## Overview
This Task Manager is a console-based application written in **C#**.  
It allows users to create, list, complete, and delete tasks, while automatically saving data to a local `tasks.json` file.  

The purpose of this software is to strengthen my skills as a software engineer by applying **core C# language concepts**—including classes, inheritance, structures, file I/O, loops, conditionals, and data persistence—in a real project.  

This project demonstrates my ability to build a fully functional, interactive console application from scratch using C#.

[📺 Software Demo Video](http://youtube.link.goes.here)

---

## Features
- Add new tasks with title, description, and due date
- List all tasks and their completion status
- Mark tasks as completed
- Delete tasks by ID
- Automatically save tasks to `tasks.json`
- Load pre-existing tasks on startup (preloaded with 3 sample tasks)
- Demonstrates:
  - Variables, expressions, loops, conditionals
  - Classes and structures
  - Abstract class + inheritance
  - File reading and writing (JSON)

---

## Development Environment
- **Language**: C# (.NET 6+ or .NET Framework)
- **Editor/IDE**: Visual Studio or Visual Studio Code
- **Libraries**:
  - `System.Text.Json` (for reading and writing JSON files)
  - `System.IO` (for file operations)

---

## How to Run
1. Clone or download this repository.
2. Open the project in Visual Studio or VS Code.
3. Make sure `tasks.json` is in the root folder of the project.
4. Press **Run** or `dotnet run` from the terminal.
5. Use the menu to add, list, complete, or delete tasks.
6. When you exit, all tasks will be saved to `tasks.json`.

---

## Useful Websites
These resources were helpful during development:

- [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [System.Text.Json Guide](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-overview)
- [W3Schools C# Tutorial](https://www.w3schools.com/cs/)
- [JSON Formatter](https://jsonformatter.org/)

---

## Future Work
Here are a few things I would like to improve in future versions:

- Add **task categories or priorities**
- Implement a **search/filter** feature
- Add **color formatting** to improve console UI
- Add **user authentication** for multiple user profiles
- Build a **GUI version** using :contentReference[oaicite:1]{index=1} (WPF) or :contentReference[oaicite:2]{index=2}

---

## Sample Preloaded Tasks
When you run the app the first time, it will load these from `tasks.json`:

```json
[
  {
    "Id": 1,
    "Title": "Finish C# Project",
    "Description": "Complete the console task manager with file saving.",
    "DueDate": "2025-09-20T00:00:00",
    "IsCompleted": false
  },
  {
    "Id": 2,
    "Title": "Review Code Comments",
    "Description": "Check that all methods have student-style comments.",
    "DueDate": "2025-09-22T00:00:00",
    "IsCompleted": false
  },
  {
    "Id": 3,
    "Title": "Create README File",
    "Description": "Write a full README with demo link and explanation.",
    "DueDate": "2025-09-25T00:00:00",
    "IsCompleted": true
  }
]
