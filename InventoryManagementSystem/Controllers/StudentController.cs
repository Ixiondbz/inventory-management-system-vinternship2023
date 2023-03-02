using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    public StudentController()
    {
    }

    [HttpGet]
    public ActionResult<List<Student>> GetAll() =>
        StudentService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Student> Get(int id)
    {
        var student = StudentService.Get(id);

        if (student == null)
            return NotFound();

        return student;
    }



    [HttpPost]
    public IActionResult Create(Student student)
    {
        StudentService.Add(student);
        return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Student student)
    {
        if (id != student.Id)
            return BadRequest();

        var existingPizza = StudentService.Get(id);
        if (existingPizza is null)
            return NotFound();

        StudentService.Update(student);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var student = StudentService.Get(id);

        if (student is null)
            return NotFound();

        StudentService.Delete(id);

        return NoContent();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        var student = StudentService.GetAll;

        if (student is null)
            return NotFound();

        StudentService.DeleteAll();

        return NoContent();
    }
}