using EF_lesson1.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson1.Entities
{
    public class Teacher:BaseEntity
    {
        [Column("IsProfessor",TypeName ="bit")]
        [Required]
        [DefaultValue(0)]
        public bool IsProfessor { get; set; }
        [Column("Salary",TypeName ="money")]
        [Range(0,double.MaxValue,ErrorMessage ="Salary can't be less than 0.")]
        public double Salary { get; set; }
        [Column("LastName",TypeName ="nvarchar(30)")]
        [Required]
        public string Surname { get; set; }
    }
}
