using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolContext _context;
        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }

        /* Crear estudiante */

        public void Add(Student studient)
        {
            _context.Add(studient);
            _context.SaveChanges();
        }

        /* Listar estudiantes */

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public IEnumerable<Student> GetByBirthday(string birthdatday)
        {
            DateTime date = DateTime.Parse(birthdatday);
            yield return _context.Students.FirstOrDefault(s => s.BirthDate == date);
        }

        /* Listar estudiante por Id */

        public Student? GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public async Task<Student> GetEmail(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(o => o.Id == id);
        }

        /* Actualizar estudante */

        public void Update(Student student)
        {
            var existingStudant = _context.Students.Find(student.Id);
            if (existingStudant != null)
            {
                existingStudant.Id = student.Id;
                existingStudant.Names = student.Names;
                existingStudant.BirthDate = student.BirthDate;
                existingStudant.Address = student.Address;
                existingStudant.Email = student.Email;
                
                _context.Students.Update(existingStudant);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Student not found");
            }
        }
    }
}