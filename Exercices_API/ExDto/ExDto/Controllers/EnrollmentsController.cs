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
    public class EnrollmentsController : ControllerBase
    {
        private readonly SchoolCoursesContext _context;

        public EnrollmentsController(SchoolCoursesContext context)
        {
            _context = context;
        }

        // GET: api/Enrollments
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Enrollment>>> GetEnrollments()
        //{
        //    return await _context.Enrollments.ToListAsync();
        //}

        public IQueryable<EnrollmentDTO> GetEnrollment()
        {
            var enrollments = from b in _context.Enrollments
                        select new EnrollmentDTO()
                        {
                            EnrollmentID = b.EnrollmentID,
                            CourseID = b.CourseID,
                            StudentID = b.StudentID,
                            Grade = b.Grade
                        };

            return enrollments;
        }

        // GET: api/Enrollments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnrollmentDetailedDTO>> GetEnrollment(int id)
        {
            var enrollment = await _context.Enrollments.Select(b =>
                new EnrollmentDetailedDTO()
                {
                    EnrollmentID = b.EnrollmentID,
                    CourseID = b.CourseID,
                    StudentID = b.StudentID,
                    Grade = b.Grade,
                    Course = b.Course,
                    Student = b.Student
                }).SingleOrDefaultAsync(b => b.EnrollmentID == id);
                        if (enrollment == null)
                        {
                            return NotFound();
                        }

                        return Ok(enrollment);
        }

        // PUT: api/Enrollments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrollment(int id, Enrollment enrollment)
        {
            if (id != enrollment.EnrollmentID)
            {
                return BadRequest();
            }

            _context.Entry(enrollment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrollmentExists(id))
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

        // POST: api/Enrollments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EnrollmentDTO>> PostEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            var dto = new EnrollmentDTO()
            {
                EnrollmentID = enrollment.EnrollmentID,
                CourseID = enrollment.CourseID,
                StudentID = enrollment.StudentID,
                Grade = enrollment.Grade
            };

            return CreatedAtAction("GetEnrollment", new { id = enrollment.EnrollmentID }, dto);
        }

        // DELETE: api/Enrollments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollments.Any(e => e.EnrollmentID == id);
        }
    }
}
