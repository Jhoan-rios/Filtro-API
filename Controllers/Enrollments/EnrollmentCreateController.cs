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
    public class EnrollmentCreateController : Controller
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        public EnrollmentCreateController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpPost]
        [Route("Enrollment/Create")]
        public IActionResult Create([FromBody] Enrollment entrollment)
        {
            _enrollmentRepository.Add(entrollment);
            return Ok();
        }
    }
}