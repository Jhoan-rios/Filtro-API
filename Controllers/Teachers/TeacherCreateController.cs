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
    public class TeacherCreateController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherCreateController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPost]
        [Route("Teacher/Create")]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            _teacherRepository.Add(teacher);
            return Ok();
        }
    }
}