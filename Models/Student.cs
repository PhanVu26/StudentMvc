using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentMvc.Models
{
     [Table("student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey("FacultyId")]
        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; }
    }
}