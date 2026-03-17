# final
# Grade Calculation System

## Description
This project is a C# Object-Oriented Programming (OOP) system used to manage course grades.  
The system allows adding students, calculating grades, and displaying statistics.

## OOP Concepts Used
- Encapsulation
- Inheritance
- Polymorphism
- Abstraction

## Class Diagram

```mermaid
classDiagram

class Person {
    <<abstract>>
    -string fullName
    +FullName
    +GetInfo()
}

class Student {
    -string studentId
    -double score
    +StudentId
    +Score
    +CalculateGrade()
    +GetInfo()
}

class Course {
    -string courseCode
    -string courseName
    -List<Student> students
    +AddStudent()
    +ShowStudents()
    +ShowStatistics()
}

class Program {
    +Main()
}

Person <|-- Student
Course "1" --> "*" Student : contains
Program --> Course : uses
