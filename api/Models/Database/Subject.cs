using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomHelperBackend.Models
{
    [Table("Subjects")]
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<TimetableSlot> TimetableSlots { get; set; }

    }
}
