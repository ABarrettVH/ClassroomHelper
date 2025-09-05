using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomHelperBackend.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<TimetableSlot> TimetableSlots { get; set; }

    }
}
