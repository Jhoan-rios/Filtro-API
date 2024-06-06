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
    public class TeachersController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeachersController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        [Route("Teacher")]
        public IEnumerable<Teacher> GetTeachers(){
            return _teacherRepository.GetAll();
        }

        [HttpGet]
        [Route("Teacher/{id}")]
        public ActionResult<Teacher> Details(int id){
            var teacher = _teacherRepository.GetById(id);
            if(teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }
    }
}