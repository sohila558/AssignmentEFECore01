using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentEFECore01.Entities
{
    internal class Course
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 12)]
        public int? Duration { get; set; }

        [Column("Cour_Name", TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string? Description { get; set; }

        [Required]
        public int? Top_Id { get; set; }
    }
}
