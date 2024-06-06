using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Services
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly SchoolContext _context;
        public EnrollmentRepository(SchoolContext context)
        {
            _context = context;
        }

        public void Add(Enrollment enrollment)
        {
            _context.Add(enrollment);
            _context.SaveChanges();
        }

        public IEnumerable<Enrollment> GetAll()
        {
            return _context.Enrollments.Include(s => s.Students).Include(s => s.Courses).ToList();
        }


        public IEnumerable<Enrollment> GetByDay(string date)
        {
            DateTime day = DateTime.Parse(date);
            yield return _context.Enrollments.Include(s => s.Students).Include(s => s.Courses).FirstOrDefault(s => s.Date == day);
        }

        public Enrollment? GetById(int id)
        {
            return _context.Enrollments.Include(s => s.Students).Include(s => s.Courses).FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Enrollment> GetByStudent(int id)
        {
            return _context.Enrollments.Where(s => s.StudentId == id).Include(s => s.Students).ToList();
        }

        public void Update(Enrollment enrollment)
        {
            var existingEnrollment = _context.Enrollments.Find(enrollment.Id);
            if (existingEnrollment != null)
            {
                existingEnrollment.Id = enrollment.Id;
                existingEnrollment.Date = enrollment.Date;
                existingEnrollment.Status = enrollment.Status;
                existingEnrollment.StudentId = enrollment.StudentId;
                existingEnrollment.CourseId = enrollment.CourseId;
                
                _context.Enrollments.Update(existingEnrollment);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Enrollmen not found");
            }
        }
    }
}