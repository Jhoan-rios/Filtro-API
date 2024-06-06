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
    public class StudentUpdateController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentUpdateController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPut]
        [Route("Student/{id}/Update")]
        public IActionResult Update([FromBody] Student student){
            _studentRepository.Update(student);
            return Ok();
        }
    }
}