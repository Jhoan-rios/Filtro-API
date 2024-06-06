using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.Services
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        IEnumerable<Course> GetByTeacher(int id);
        Course? GetById(int id);
        void Add(Course course);
        void Update(Course course);
    }
}