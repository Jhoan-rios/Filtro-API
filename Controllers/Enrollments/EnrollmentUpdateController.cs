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
    public class EnrollmentUpdateController : Controller
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        public EnrollmentUpdateController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpPut]
        [Route("Enrollment/{id}/Update")]
        public IActionResult Update([FromBody] Enrollment enrollment){
            _enrollmentRepository.Update(enrollment);
            return Ok();
        }
    }
}