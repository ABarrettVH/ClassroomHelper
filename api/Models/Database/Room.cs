using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomHelperBackend.Models
{
    [Table("Rooms")]
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Tables { get; set; } = string.Empty;

        public ICollection<TimetableSlot> TimetableSlots { get; set; }

    }
}
