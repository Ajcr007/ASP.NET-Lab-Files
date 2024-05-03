using System.ComponentModel.DataAnnotations;
namespace Form_Tag_Helper.Models
{
    public class Employee
    {
        public string? Ename { get; set; }
        public int Eid { get; set; }
        public Gender Gender { get; set; }
        public string? Mstatus { get; set; }
        public string? Description { get; set; }
    }
    public enum Gender { Male, Female }
}
