using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetByBirthday(string date);
        Student? GetById(int id);
        void Add(Student studient);
        void Update(Student studient);
        Task<Student> GetEmail(int id);
    }
}