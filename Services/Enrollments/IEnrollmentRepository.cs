using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.Services
{
    public interface IEnrollmentRepository
    {
        IEnumerable<Enrollment> GetAll();
        Enrollment? GetById(int id);
        IEnumerable<Enrollment> GetByDay(string date);
        IEnumerable<Enrollment> GetByStudent(int id);
        void Add(Enrollment enrollment);
        void Update(Enrollment enrollment);
    }
}