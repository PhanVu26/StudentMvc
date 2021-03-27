using System.Collections.Generic;
using System.Linq;
using StudentMvc.Models;

namespace StudentMvc.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly DataContext _context;

        public FacultyService(DataContext context) { 
            _context = context;
        }
       
        public void AddNewFaculty(Faculty faculty)
        {
            _context.Add(faculty);
            _context.SaveChanges();
        }

        public void DeleteFaculty(int facultyId)
        {
            var faculty = GetFacultyById(facultyId);
            if(faculty == null){
                return;
            }
            _context.Faculties.Remove(faculty);
            _context.SaveChanges();
        }

        public void EditFaculty(Faculty faculty)
        {
            var editFaculty = GetFacultyById(faculty.Id);
            if(editFaculty == null){
                return;
            }
            editFaculty.Name = faculty.Name;
            _context.SaveChanges();
        }

        public List<Faculty> GetFaculties()
        {
            return _context.Faculties.ToList();
        }

        public Faculty GetFacultyById(int facultyId)
        {
            return _context.Faculties.FirstOrDefault(f => f.Id == facultyId);
        }
    }
}