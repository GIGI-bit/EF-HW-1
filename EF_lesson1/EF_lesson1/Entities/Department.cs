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
    public class Department:BaseEntity
    {
        [Range(1,5)]
        public int? BuildingNumber {  get; set; }
        [Column("Financing",TypeName ="money")]
        public double? Financing {  get; set; }

        public int? FacultyId { get; set; }
        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }
    }
}
