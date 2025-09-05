using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomHelperBackend.Models
{
    [Table("TimetableSlots")]
    public class TimetableSlot
    {
        public int TimetableSlotId { get; set; }
        public string Day { get; set; } = string.Empty;
        public int Period { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public int RoomId { get; set; }

        public Teacher Teacher { get; set; } = null!;
        public Lesson Lesson { get; set; } = null!;
        public Room Room { get; set; } = null!;
    }
}
