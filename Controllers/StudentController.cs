using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentMvc.Models;
using StudentMvc.Services;

namespace StudentMvc.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;

        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            // var students = _context.Students.ToList();

            // students.Add(new Student{Id = 1, Name = "Phan Vu", Age=22, Address="Gia Lai"});
            // students.Add(new Student{Id = 2, Name = "Phan Vu1", Age=22, Address="Gia Lai"});
            // students.Add(new Student{Id = 3, Name = "Phan Vu2", Age=22, Address="Gia Lai"});
            //Viewbag.students
            //ViewData["students"] = students;
            return View(students);
        }

        public IActionResult AddStudent()
        {
           
            
            return View();
        }
        public IActionResult SaveStudent(Student student)
        {
            if(student.Id == 0){
                _studentService.AddNewStudent(student);
            }
            else _studentService.EditStudent(student);
            return RedirectToAction("index");
        }

        public IActionResult EditStudent(int id)
        {
            var student  = _studentService.GetStudentById(id);
            return View(student);
        }

        // public IActionResult SaveEditStudent(Student student)
        // {
        //     _studentService.EditStudent(student);
        //     return RedirectToAction("index");
        // }

        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("index");
        }
    }
}