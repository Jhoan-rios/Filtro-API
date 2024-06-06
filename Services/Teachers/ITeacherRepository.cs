using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.Services
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher? GetById(int id);
        void Add(Teacher teacher);
        void Update(Teacher teacher);
    }
}