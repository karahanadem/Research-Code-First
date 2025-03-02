# Entity Framework Code First - Student Database Example

This is a simple console application that demonstrates the Entity Framework Code First approach to create a student database and add a student record.

## Overview

Entity Framework Code First allows developers to define their database model using C# classes. The database schema is then automatically generated from these classes. This approach is particularly useful for domain-driven design and when the domain model is the primary focus.

## Features

- Creates a Student database using Code First approach
- Adds a student record to the database
- Retrieves and displays all students from the database

## Requirements

- .NET 9.0
- Entity Framework 6.5.1
- SQL Server LocalDB

## How It Works

1. The application defines a `Student` model class with properties like StudentID, FirstName, LastName, etc.
2. A `StudentContext` class derived from DbContext is created to manage database connections and operations.
3. The application creates a new student, adds it to the database, and then retrieves all students.

## Code First Workflow

1. Define entity classes (models)
2. Configure the database context
3. Entity Framework creates the database based on your model
4. Perform CRUD operations using the context

## Key Concepts Demonstrated

- Entity definition with data annotations
- DbContext configuration
- Fluent API for model configuration
- Database initialization
- Basic CRUD operations 