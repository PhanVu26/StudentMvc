using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentMvc.Models
{
    [Table("Faculty")]
    public class Faculty
    {

        public Faculty()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Student> Students { get; set; }
    }
}