# final
     Person (abstract)
- fullName : string
+ GetInfo()

Student : Person
- studentId : string
- score : double
+ CalculateGrade()
+ GetInfo()

Course
- courseCode : string
- courseName : string
- students : List<Student>
+ AddStudent()
+ ShowStudents()
+ ShowStatistics()

Program
+ Main()
