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
    public class Group:BaseEntity
    {
        [Range(1,5)]
        public int? Year { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }

        public IEnumerable<Curator> Curators { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Lecture> Lectures { get; set;}
    }

}
