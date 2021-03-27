using System.Collections.Generic;

namespace StudentMvc.Models
{
    public class EditViewModel
    {
        public Student Student { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}