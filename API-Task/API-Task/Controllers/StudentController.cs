using API_Task.Data;
using API_Task.Models;
using API_Task.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            List<DTOstudent> DTOstudents = new List<DTOstudent>();

            foreach (var item in _appDbContext.Students.ToList())
            {
                DTOstudent Dtostudent = new DTOstudent();
                Dtostudent.Name = item.Name;
                Dtostudent.SurName = item.SurName;
                Dtostudent.Age = item.Age;
                Dtostudent.Phone = item.Phone;
                Dtostudent.Email = item.Email;
                Dtostudent.ClassNumber = item.ClassNumber;
                Dtostudent.School = _appDbContext.Schools.Select(p => new { p.Id, p.Name }).FirstOrDefault(r=>r.Id == item.SchoolId);

                DTOstudents.Add(Dtostudent);
            }
            return Ok(DTOstudents);
        }


        [HttpGet("{id}")]
        public IActionResult GetStudent(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Error!");
            }

            Student student = _appDbContext.Students.Find(id);
            if (student == null)
            {
                ModelState.AddModelError("", "Error!");
                return StatusCode(StatusCodes.Status404NotFound, ModelState);

                //return StatusCode(StatusCodes.Status400BadRequest, "Aee naqardin?!");
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Students.Add(student);
                _appDbContext.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }


    }
}
