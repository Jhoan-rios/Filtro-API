using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Models;
using School.Services;

namespace School.Controllers
{
    public class EnrollmentsController : Controller
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        public EnrollmentsController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpGet]
        [Route("Enrollment")]
        public IEnumerable<Enrollment> GetEnrollments(){
            return _enrollmentRepository.GetAll();
        }

        [HttpGet]
        [Route("Enrollment/{id}")]
        public ActionResult<Enrollment> Details(int id){
            var enrollment = _enrollmentRepository.GetById(id);
            if(enrollment == null)
            {
                return NotFound();
            }
            return Ok(enrollment);
        }

        [HttpGet]
        [Route("Enrollment/{date}/date")]
        public IEnumerable<Enrollment> GetByDay(string date){
            return _enrollmentRepository.GetByDay(date);
        }

        [HttpGet]
        [Route("students/{id}/enrollments")]
        public IEnumerable<Enrollment> GetEnrollmentByStudent(int id){
            return _enrollmentRepository.GetByStudent(id);
        }
    }
}