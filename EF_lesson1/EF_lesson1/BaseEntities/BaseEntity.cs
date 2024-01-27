using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson1.BaseEntities
{
    public abstract class BaseEntity
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public BaseEntity()
        {
            
        }
    }
}
