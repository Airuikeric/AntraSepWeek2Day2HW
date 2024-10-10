namespace Week2Day2HW;
using System;
using System.Collections.Generic;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    private decimal salary;
    public string Address { get; set; }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    public abstract decimal CalculateSalary();
}

public class Student : Person
{
    public List<Course> Courses { get; set; } = new List<Course>();
    public double GPA { get; private set; }

    public void CalculateGPA()
    {
        // Logic to calculate GPA based on courses and grades
    }

    public override decimal CalculateSalary()
    {
        return 0; // Students may not have salary
    }
}

public class Instructor : Person
{
    public string Department { get; set; }
    public bool IsHeadOfDepartment { get; set; }
    public DateTime JoinDate { get; set; }

    public override decimal CalculateSalary()
    {
        // Base salary + bonus based on years of experience
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        return Salary + (yearsOfExperience * 500); // Example bonus calculation
    }
}

public class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();
}

public class Department
{
    public string DepartmentName { get; set; }
    public Instructor HeadInstructor { get; set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
}

public interface IPersonService
{
    void GetAddress();
    void CalculateAge();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    void CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    void AssignDepartment(Department department);
    decimal CalculateBonus();
}
