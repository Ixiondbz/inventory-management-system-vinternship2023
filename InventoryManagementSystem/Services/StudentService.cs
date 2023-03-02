using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services;

public static class StudentService
{
    static List<Student> Students { get; }
    static int nextId = 2;
    static StudentService()
    {
        Students = new List<Student>
        {
            new Student { Id = 1, UserName = "ikkhon123", Password="SecretPass482",UserFirstName="Ikkhon",UserLastName="Chowdhury",Email="ixionchowdhury@gmail.com",Phone="01771064027",Address="Bashundhara R/A",Role="SomeRole"}
        };
    }

    public static List<Student> GetAll() => Students;



    public static Student? Get(string userfirstname) => Students.FirstOrDefault(p => p.UserFirstName == userfirstname);
    public static Student? Get(int id) => Students.FirstOrDefault(p => p.Id == id);

    public static void Add(Student student)
    {
        student.Id = nextId++;
        Students.Add(student);
    }

    public static void Delete(int id)
    {
        var student = Get(id);
        if (student is null)
            return;

        Students.Remove(student);
    }

    public static void DeleteAll()
    {
        var students = GetAll();
        if (students is null)
            return;

        Students.Clear();
    }

    public static void Update(Student student)
    {
        var index = Students.FindIndex(p => p.Id == student.Id);
        if (index == -1)
            return;

        Students[index] = student;
    }
}