using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Services
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolContext _context;
        public CourseRepository(SchoolContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.Include(s => s.Teachers).ToList();
        }

        public Course? GetById(int id)
        {
            return _context.Courses.Include(s => s.Teachers).FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Course> GetByTeacher(int id)
        {
            return _context.Courses.Where(s => s.TeacherId == id).Include(s => s.Teachers).ToList();
        }

        public void Update(Course course)
        {
            var existingCourse = _context.Courses.Find(course.Id);
            if (existingCourse != null)
            {
                existingCourse.Id = course.Id;
                existingCourse.Name = course.Name;
                existingCourse.Description = course.Description;
                existingCourse.Schedule = course.Schedule;
                existingCourse.Duration = course.Duration;
                existingCourse.Capacity = course.Capacity;
                existingCourse.TeacherId = course.TeacherId;
                
                _context.Courses.Update(existingCourse);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Course not found");
            }
        }
    }
}