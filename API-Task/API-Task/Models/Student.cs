using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Task.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string SurName { get; set; }
        public byte Age { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string ClassNumber{ get; set; }
        [ForeignKey("School")]
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
