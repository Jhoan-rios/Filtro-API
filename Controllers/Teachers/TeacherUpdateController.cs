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
    public class TeacherUpdateController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherUpdateController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPut]
        [Route("Teacher/{id}/Update")]
        public IActionResult Update([FromBody] Teacher teacher){
            _teacherRepository.Update(teacher);
            return Ok();
        }
    }
}