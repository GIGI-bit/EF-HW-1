using EF_lesson1.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson1.Entities
{
    public class Student:BaseEntity
    {
        [Required]
        [Column("Lastname",TypeName ="nvarchar(30)")]
        public string Surname { get; set; }
        [Required]
        public int Rating { get; set; }
        public IEnumerable<Group> Groups { get; set; }
    }
}
