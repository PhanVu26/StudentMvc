using System.Collections.Generic;
using StudentMvc.Models;
using System.Linq;

namespace StudentMvc.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;

        public StudentService(DataContext context){
            _context = context;
        }
        public void AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var student = GetStudentById(studentId);
            if(student == null){
                return;
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public void EditStudent(Student student)
        {
            var editStudent = GetStudentById(student.Id);
            if(editStudent == null){
                return;
            }
            editStudent.Name = student.Name;
            editStudent.Age = student.Age;
            editStudent.Address = student.Address;

            _context.SaveChanges();
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return _context.Students.FirstOrDefault(s => s.Id == studentId); 
        }
    }
}