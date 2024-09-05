using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExDto.Db;
using ExDto.Models;

namespace ExDto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolCoursesContext _context;

        public StudentsController(SchoolCoursesContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public IQueryable<StudentDTO> GetEnrollment()
        {
            var students = from b in _context.Students
                              select new StudentDTO()
                              {
                                  Id = b.Id,
                                  Name = b.Name,
                                  Firstname = b.Firstname,
                                  Enrollments = b.Enrollments
                              };

            return students;
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDTO>> GetStudent(int id)
        {
            var student = await _context.Students.Select(b =>
                new StudentDTO()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Firstname = b.Firstname,
                    Enrollments = b.Enrollments
                }).SingleOrDefaultAsync(b => b.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            var dto = new StudentDTO()
            {
                Id = student.Id,
                Name = student.Name,
                Firstname = student.Firstname,
                Enrollments = student.Enrollments
            };

            return CreatedAtAction("GetStudent", new { id = student.Id }, dto);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
