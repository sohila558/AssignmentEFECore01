using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentEFECore01.Entities
{
    internal class Instructor
    {
        [Key]
        [Column("Id")]
        public int Ins_Id { get; set; }

        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public double Bonus { get; set; }


        [Column(TypeName = "money")]
        public double Salary { get; set; }

        [Required]
        public string? Address { get; set; }

        [Column(TypeName = "money")]
        public double HourRate { get; set; }
        public int Dept_Id { get; set; }
    }
}
