using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Models;
using School.Services;

namespace Filtro_API.Controllers.Studients
{
    public class StudentCreateController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentCreateController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        [Route("Student/Create")]
        public IActionResult Create([FromBody] Student student)
        {
            _studentRepository.Add(student);
            return Ok();
        }
    }
}