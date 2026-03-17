# final
                <<abstract>>
                 Person
        -------------------------
        - fullName : string
        -------------------------
        + FullName : string
        + GetInfo() : string
                ▲
                │
                │ Inheritance
                │
             Student
        -------------------------
        - studentId : string
        - score : double
        -------------------------
        + StudentId : string
        + Score : double
        + CalculateGrade() : string
        + GetInfo() : string
        

             Course
        -------------------------
        - courseCode : string
        - courseName : string
        - students : List<Student>
        -------------------------
        + AddStudent(student)
        + ShowStudents()
        + ShowStatistics()
        

             Program
        -------------------------
        + Main()
