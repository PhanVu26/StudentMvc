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
        private readonly IFacultyService _facultyService;

        public StudentController(IStudentService studentService, IFacultyService facultyService)
        {
            _studentService = studentService;
            _facultyService  = facultyService;

        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            foreach(var st in students){
                st.Faculty = _facultyService.GetFacultyById(st.FacultyId);
            }
            var faculties = _facultyService.GetFaculties();
            ViewModel viewModel = new ViewModel{Students = students, Faculties = faculties};
           
            // viewModel.Students = students;
            // viewModel.Faculties = faculties;
            // var students = _context.Students.ToList();

            // students.Add(new Student{Id = 1, Name = "Phan Vu", Age=22, Address="Gia Lai"});
            // students.Add(new Student{Id = 2, Name = "Phan Vu1", Age=22, Address="Gia Lai"});
            // students.Add(new Student{Id = 3, Name = "Phan Vu2", Age=22, Address="Gia Lai"});
            //Viewbag.students
            //ViewData["students"] = students;
            return View(viewModel);
        }

        public IActionResult AddStudent()
        {

            var faculties = _facultyService.GetFaculties();
            return View(faculties);
        }
        public IActionResult SaveStudent(Student student)
        {
            student.Faculty = _facultyService.GetFacultyById(student.FacultyId);
            if (student.Id == 0)
            {
                _studentService.AddNewStudent(student);
            }
            else _studentService.EditStudent(student);
            return RedirectToAction("index");
        }

        public IActionResult EditStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            var faculties = _facultyService.GetFaculties();

            EditViewModel editViewModel = new EditViewModel{Student = student, Faculties = faculties};
            return View(editViewModel);
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