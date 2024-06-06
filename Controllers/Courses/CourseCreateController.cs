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
    public class CourseCreateController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CourseCreateController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPost]
        [Route("Course/Create")]
        public IActionResult Create([FromBody] Course course)
        {
            _courseRepository.Add(course);
            return Ok();
        }
    }
}