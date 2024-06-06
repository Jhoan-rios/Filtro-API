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
    public class CoursesController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        [Route("Course")]
        public IEnumerable<Course> GetCourses(){
            return _courseRepository.GetAll();
        }

        [HttpGet]
        [Route("Course/{id}")]
        public ActionResult<Course> Details(int id){
            var course = _courseRepository.GetById(id);
            if(course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpGet]
        [Route("teachers/{id}/courses")]
        public IEnumerable<Course> GetCoursesTeachers(int id){
            return _courseRepository.GetByTeacher(id);
        }
    }
}