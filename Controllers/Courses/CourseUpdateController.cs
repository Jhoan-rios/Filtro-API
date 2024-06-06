using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Services;

namespace School.Controllers
{
    public class CourseUpdateController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CourseUpdateController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        
    }
}