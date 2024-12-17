using System.ComponentModel.DataAnnotations;

namespace CRUDAPPUsing_CRUDWEBAPI.Models
{
        public class Student
        {
        [Required]
        public int id { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentGender { get; set; }
        [Required]
        public int studentAge { get; set; }
        [Required]
        public int standard { get; set; }
        }
}
