using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Data;
using School.Models;

namespace School.Services
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolContext _context;
        public TeacherRepository(SchoolContext context)
        {
            _context = context;
        }

        public void Add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }
        

        public Teacher? GetById(int id)
        {
            return _context.Teachers.FirstOrDefault(s => s.Id == id);
        }

        public void Update(Teacher teacher)
        {
            var existingTeacher = _context.Teachers.Find(teacher.Id);
            if (existingTeacher != null)
            {
                existingTeacher.Id = teacher.Id;
                existingTeacher.Names = teacher.Names;
                existingTeacher.Specialty = teacher.Specialty;
                existingTeacher.Phone = teacher.Phone;
                existingTeacher.Email = teacher.Email;
                existingTeacher.YearsExperience = teacher.YearsExperience;
                
                _context.Teachers.Update(existingTeacher);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Teacher not found");
            }
        }
    }
}