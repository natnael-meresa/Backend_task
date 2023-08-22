using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : ControllerBase
{
  private readonly SchoolAppContext _context;

  public TeachersController(SchoolAppContext context)
  {
    _context = context;
  }

  // GET: api/teachers
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
  {
    return await _context.Teachers.ToListAsync();
  }

  // GET: api/teachers/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Teacher>> GetTeacher(int id)
  {
    var teacher = await _context.Teachers.FindAsync(id);

    if (teacher == null)
    {
      return NotFound();
    }

    return teacher;
  }

  // POST api/teachers
  [HttpPost]
  public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
  {
    _context.Teachers.Add(teacher);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetTeacher), new { id = teacher.Id }, teacher);
  }

  // PUT api/teachers/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
  {
    if (id != teacher.Id)
    {
      return BadRequest();
    }

    _context.Entry(teacher).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return Ok(await _context.Teachers.FindAsync(id));

  }

  // DELETE api/teachers/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteTeacher(int id)
  {
    var teacher = await _context.Teachers.FindAsync(id);

    if (teacher == null)
    {
      return NotFound();
    }

    _context.Teachers.Remove(teacher);
    await _context.SaveChangesAsync();

    return Ok(teacher);
  }
}