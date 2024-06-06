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
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("Student")]
        public IEnumerable<Student> GetStudents(){
            return _studentRepository.GetAll();
        }

        [HttpGet]
        [Route("Student/{id}")]
        public ActionResult<Student> Details(int id){
            var student = _studentRepository.GetById(id);
            if(student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpGet]
        [Route("students/{birthday}/birthday")]
        public ActionResult<Student> GetByBirthday(string birthday){
            var student = _studentRepository.GetByBirthday(birthday);
            if(student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}