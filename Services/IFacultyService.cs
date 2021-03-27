using System.Collections.Generic;
using StudentMvc.Models;

namespace StudentMvc.Services
{
    public interface IFacultyService
    {
        List<Faculty> GetFaculties();
        Faculty GetFacultyById(int facultyId);
        void AddNewFaculty(Faculty faculty);
        void EditFaculty(Faculty faculty);
        void DeleteFaculty(int facultyId); 
    }
}