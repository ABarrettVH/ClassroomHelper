using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomHelperBackend.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        [Column("Id")]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}
