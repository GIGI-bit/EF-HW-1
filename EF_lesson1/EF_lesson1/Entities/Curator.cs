using EF_lesson1.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson1.Entities
{
    public class Curator:BaseEntity
    {
        [Column("LastName", TypeName = "nvarchar(30)")]
        [Required]
        public string? Surname { get; set; }
       public IEnumerable<Group> Groups { get; set; }
    }
}
