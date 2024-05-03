using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Column("Empname",TypeName ="varchar(100)")]
        public String? Ename { get; set; }
        public String? Designation { get; set; }
    }
}
