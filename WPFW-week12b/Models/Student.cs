using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPFW_week12b.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }
        [MaxLength(14)]
        public string PhoneNumber { get; set; }
        [Display(Name = "BirthDay")]
        [Required]
        public string DateOfBirth { get; set; }
        [StringLength(40)]
        public string Addres { get; set; }
        [StringLength(40)]
        public string Place { get; set; }

        public List<Student> Friends { get; set; }
    }
}
