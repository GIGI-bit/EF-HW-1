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
    public class Lecture
    {
        [Key]
        public int Id { get; set; }

        [Column(nameof(LectureDate),TypeName ="date")]
        public DateTime LectureDate { get; set; }

        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }
        [ForeignKey(name: nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        public IEnumerable<Group> Groups { get; set; }

    }
}
