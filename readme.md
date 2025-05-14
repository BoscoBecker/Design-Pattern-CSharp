[![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)](#)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

# Design Patterns in C# - Udemy Course
https://www.udemy.com/course/design-patterns-gof

This repository showcases practical implementations of **Design Patterns** in C#, organized into three main categories: Creational, Structural, and Behavioral.

---

## 📋 Table of Contents

1. [Overview](#overview)
2. [Implemented Patterns](#implemented-patterns)
3. [How to Build and Run](#how-to-build-and-run)
    - [Locally](#locally)
    - [Via Docker](#via-docker)
4. [Usage Example](#usage-example)
5. [Contributing](#contributing)
6. [License](#license)

---

## 🔍 Overview

This project was created to demonstrate, in a didactic way, how to apply the most common **Design Patterns** in C#. Each pattern includes:

- **Description**: What it is and when to use it.
- **Implementation**: Step-by-step commented code.
- **Execution Example**: Console demonstration.

---


## 🧩 Implemented Patterns

### 1. Creational
- **Factory Method**: Creates objects without exposing instantiation logic.
- **Singleton**: Ensures a class has only one instance.
- **Abstract Factory**: Factory of factories for families of objects.

### 2. Structural
- **Adapter**: Converts the interface of a class into another interface clients expect.
- **Decorator**: Adds responsibilities to objects dynamically.
- **Composite**: Treats individual objects and compositions uniformly.

### 3. Behavioral
- **Strategy**: Encapsulates algorithms, making them interchangeable.
- **Observer**: Notifies dependents when a state changes.
- **Command**: Encapsulates requests as objects.

---

## ⚙️ How to Build and Run

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/)
- [Docker](https://www.docker.com/) (optional)
- [Docker Compose](https://docs.docker.com/compose/) (optional)

### Locally

1. Clone the repository and navigate to the folder:
   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```
2. Build and run:
   ```bash
   dotnet build
   dotnet run --project Program.cs
   ```

### Via Docker

1. Build the image:
   ```bash
   docker-compose build
   ```
2. Run the container:
   ```bash
   docker-compose up
   ```
3. The terminal output will show each pattern in action.

---

## 🚀 Usage Example

When you run the application, you’ll see something like this in the console:

```
--- Factory Method ---
Creating Product A…
Product A created successfully!

--- Singleton ---
Unique instance obtained: ID 1
Unique instance obtained: ID 1

--- Strategy ---
Processing with Strategy X…
Processing with Strategy Y…

…
```

Each block corresponds to one of the patterns implemented in `Patterns/`.

---

## 🤝 Contributing

1. Fork this repository.
2. Create a branch (e.g., `feature/NewPattern`).
3. Make your changes and commit (`git commit -m "Add XYZ Pattern"`).
4. Push to your branch.
5. Open a Pull Request describing your changes.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute!

---

*README.md updated on May 14, 2025*  
